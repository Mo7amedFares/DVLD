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

    public partial class UC_SearchPeoble : UserControl
    {
        public delegate void DataBackDelegate(object sender, int id);
        public event DataBackDelegate? DataBackEvent;

        private int personID = -1;
        public UC_SearchPeoble()
        {
            InitializeComponent();
            CPoxFilterBy.SelectedIndex = 0;

        }
        public void LoadData(int userId)
        {
            personID = userId;
            UserService userService = UserService.GetUserById(userId);
            if (userService == null)
            {
                MessageBox.Show("User not found.");
                return;
            }
            uC_PersonInfomation1.loadData(userService);
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
                errorProvider1.SetError(tbTextFiltter, "");
                personID = user.User_ID;
                DataBackEvent?.Invoke(this, personID);
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

    }
}
