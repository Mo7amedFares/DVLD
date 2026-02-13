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

            CPoxFilterBy.SelectedIndex = 0;

        }

        private void LoadUserData()
        {
            lblAddOrUpdateSystemUser.Text = "Update System User";
            lblSystemUserId.Text = systemUserID.ToString();
            uC_PersonInfomation1.loadData(DVLD_BusinessLogicLayer.UserService.GetUserById(personID));
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

        private void CPoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CPoxFilterBy.SelectedItem == null)
            {
                tbTextFiltter.Visible = false;
                button1.Visible = false;
            }
            else
            {
                tbTextFiltter.Visible = true;
                button1.Visible = true;
            }
        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTextFiltter.Text))
            {
                return;
            }
            if (CPoxFilterBy.SelectedItem.ToString() == "User_ID")
            {
                if (!int.TryParse(tbTextFiltter.Text, out int userId))
                {
                    tbTextFiltter.Text = tbTextFiltter.Text.Remove(tbTextFiltter.Text.Length - 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // امسح الأخطاء القديمة
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(tbTextFiltter.Text))
            {
                errorProvider1.SetError(tbTextFiltter, "This field is required.");
                return;
            }

            if (CPoxFilterBy.SelectedItem.ToString() == "User_ID" &&
                !int.TryParse(tbTextFiltter.Text, out _))
            {
                errorProvider1.SetError(tbTextFiltter, "Please enter a valid number.");
                return;
            }

            UserService user = null;

            switch (CPoxFilterBy.SelectedItem.ToString())
            {
                case "User_ID":
                    user = DVLD_BusinessLogicLayer.UserService.GetUserById(Convert.ToInt32(tbTextFiltter.Text));
                    break;
                case "SSN":
                    user = DVLD_BusinessLogicLayer.UserService.GetUserBySSN(tbTextFiltter.Text);
                    break;
                case "Email":
                    user = DVLD_BusinessLogicLayer.UserService.GetUserByEmail(tbTextFiltter.Text);
                    break;
                case "Phone":
                    user = DVLD_BusinessLogicLayer.UserService.GetUserByPhone(tbTextFiltter.Text);
                    break;
            }

            if (user == null)
            {
                errorProvider1.SetError(tbTextFiltter, "User not found.");
                personID = -1;
            }
            else
            {
                errorProvider1.SetError(tbTextFiltter, ""); // امسح الخطأ
                personID = user.User_ID;
            }

            uC_PersonInfomation1.loadData(user);
        }


        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            NewOrUpdateUserForm newOrUpdateUserForm = new NewOrUpdateUserForm(-1);
            newOrUpdateUserForm.DataBackEvent += NewOrUpdateUserForm_DataBackEvent;
            newOrUpdateUserForm.ShowDialog();
        }

        private void NewOrUpdateUserForm_DataBackEvent(object sender, int id)
        {
            tbTextFiltter.Text = id.ToString();
            button1_Click(this, EventArgs.Empty); // إعادة تحميل البيانات بعد إضافة مستخدم جديد
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (personID != -1)
            {
                tabPage2.Enabled = true;
                tabControl1.SelectedTab = tabPage2;
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
