using DVLD_BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class AddOrUpdateSystemUserForm : Form
    {
        private int personID = -1;
        private int systemUserID = -1;
        private SystemUserService systemUser;
        public AddOrUpdateSystemUserForm(int systemUserId)
        {

            InitializeComponent();
            uC_SearchPeoble1.DataBackEvent += Uc_SearchPeoble1_DataBackEvent;
            tbPassword.UseSystemPasswordChar = true;
            tbConfirmPassword.UseSystemPasswordChar = true;
            tbPassword.PasswordChar = '*';
            tbConfirmPassword.PasswordChar = '*';
            if (systemUserId != -1)
            {
                systemUserID = systemUserId;
                systemUser = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUserById(systemUserId);
                personID = systemUser.User_ID;
                LoadUserData();
            }
            else
                tabPage2.Enabled = false;


        }

        private void LoadUserData()
        {
            lblAddOrUpdateSystemUser.Text = "Update System User";
            lblSystemUserId.Text = systemUserID.ToString();
            uC_SearchPeoble1.LoadData(systemUser.User_ID);
            tabPage1.Enabled = false;
            tabPage2.Enabled = true;
            tbUserName.Text = systemUser.Username;
            tbPassword.Text = systemUser.Password;
            tbConfirmPassword.Text = systemUser.Password;
            tbConfirmPassword.Enabled = false;
            tbPassword.Enabled = false;
            cbIsActive.Checked = systemUser.IsActive;
            tabControl1.SelectedTab = tabPage2;
        }

        private void Uc_SearchPeoble1_DataBackEvent(object sender, int id)
        {
            personID = id;
        }

        private bool IsAlredyHaveSystemUser(int userId)
        {
            return SystemUserService.isExistByUserId(userId);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (personID != -1)
            {
                tabPage2.Enabled = true;
                tabControl1.SelectedTab = tabPage2;
                if(IsAlredyHaveSystemUser(personID))
                {
                    MessageBox.Show("This user already has a system user account. You can only update the existing account.", "User Already Has System Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    systemUser = SystemUserService.GetSystemUserByUserId(personID);
                    systemUserID = systemUser.System_User_Id;
                    LoadUserData();
                }

            }
            else
            {
                tabPage2.Enabled = false;
                MessageBox.Show("Please select a user before proceeding to the next page.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider1.SetError(tbConfirmPassword, "Both password fields are required.");
                return;
            }

            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords do not match.");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, ""); // امسح الخطأ
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // امسح الأخطاء القديمة
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "Username is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Password is required.");
                return;
            }
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords do not match.");
                return;
            }
            bool isActive = cbIsActive.Checked;
            if (systemUserID == -1)
            {
                systemUser = new SystemUserService
                {
                    User_ID = personID,
                    Username = tbUserName.Text,
                    Password = tbPassword.Text,
                    //Permission = null,
                    IsActive = isActive
                };
                systemUser.mode = SystemUserService.enMode.Add;
            }
            else
            {
                systemUser.User_ID = personID;
                systemUser.Username = tbUserName.Text;
                systemUser.Password = tbPassword.Text;
                systemUser.IsActive = isActive;
                systemUser.mode = SystemUserService.enMode.Update;
            }
            if (systemUser.Save())
            {
                MessageBox.Show("System user saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save system user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
