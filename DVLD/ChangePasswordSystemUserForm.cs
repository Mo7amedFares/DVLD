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
    public partial class ChangePasswordSystemUserForm : Form
    {
        private SystemUserService userService;
        public ChangePasswordSystemUserForm(int system_User_id)
        {
            InitializeComponent();
            uS_SystemUserInfo1.loadData(system_User_id);
        }

        private void tbCurentPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurentPassword.Text))
            {
                errorProvider1.SetError(tbCurentPassword, "Current password is required.");
            }
            else
            {
                errorProvider1.SetError(tbCurentPassword, string.Empty);
            }
        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text))
            {
                errorProvider1.SetError(tbNewPassword, "New password is required.");
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, string.Empty);
            }
        }

        private void tbConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmNewPassword.Text))
            {
                errorProvider1.SetError(tbConfirmNewPassword, "Confirm new password is required.");
            }
            else if (tbConfirmNewPassword.Text != tbNewPassword.Text)
            {
                errorProvider1.SetError(tbConfirmNewPassword, "Passwords do not match.");
            }
            else
            {
                errorProvider1.SetError(tbConfirmNewPassword, string.Empty);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCurentPassword.Text != userService.Password)
            {
                if (MessageBox.Show("Current password is incorrect. Do you want to proceed?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (userService.ChangePassword(tbNewPassword.Text))
            {
                MessageBox.Show("Password changed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please try again.");
            }
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
