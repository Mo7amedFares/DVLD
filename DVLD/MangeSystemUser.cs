using DVLD;
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
    public partial class MangeSystemUser : Form
    {
        private DataTable usersTable;
        private string currentSortColumn;
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;
        public MangeSystemUser()
        {
            InitializeComponent();
            AddItemsToFilterByComboBox();
            fillUsersDataGridView();
            dataGridViewUsers.ColumnHeaderMouseClick += DataGridViewUsers_ColumnHeaderMouseClick;
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            AddOrUpdateSystemUserForm addNewSystemUserForm = new AddOrUpdateSystemUserForm(-1);
            addNewSystemUserForm.ShowDialog();
            fillUsersDataGridView();
        }

        //private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SystemUserInfoForm systemUserInfoForm = new SystemUserInfoForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["System_User_id"].Value));
        //    systemUserInfoForm.ShowDialog();
        //}





        //private void BtnAddNewUser_Click(object sender, EventArgs e)
        //{
        //    NewOrUpdateUserForm newUserForm = new NewOrUpdateUserForm(-1);
        //    newUserForm.ShowDialog();
        //    fillUsersDataGridView();
        //}

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // If this was the active child, clear it
            if (MainForm.currentChildForm == this)
                MainForm.currentChildForm = null;
        }

        private void fillUsersDataGridView()
        {
            dataGridViewUsers.DataSource = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //private void editToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    NewOrUpdateUserForm updateUserForm = new NewOrUpdateUserForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["User_ID"].Value));
        //    updateUserForm.ShowDialog();
        //    fillUsersDataGridView();
        //}

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemUserService.Delete(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["System_User_ID"].Value));
            fillUsersDataGridView();
        }

        //private void addPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    NewOrUpdateUserForm newUserForm = new NewOrUpdateUserForm(-1);
        //    newUserForm.ShowDialog();
        //    fillUsersDataGridView();
        //}

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillUsersDataGridView();
        }



        private void AddItemsToFilterByComboBox()
        {
            CPoxFilterBy.Items.Add("None");
            // Add other filter options as needed
            CPoxFilterBy.Items.Add("system_user_id");
            CPoxFilterBy.Items.Add("User_ID");
            CPoxFilterBy.Items.Add("Username");
            CPoxFilterBy.Items.Add("isActive");
            CPoxFilterBy.Items.Add("Permission");

            CPoxFilterBy.SelectedIndex = 0; // Set default selection
        }
        private void CPoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example filter implementation
            DataTable usersTable;
            // add downList filter options

            if (CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                CbIsActive.Visible = false;
                dataGridViewUsers.DataSource = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();
                tbTextFiltter.Hide();

            }
            else if (CPoxFilterBy.SelectedItem.ToString() == "isActive")
            {
                CbIsActive.Visible = true;
                CbIsActive.SelectedIndex = 0; // Set default selection

                tbTextFiltter.Hide();
            }
            else
            {
                CbIsActive.Visible = false;
                tbTextFiltter.Show();
            }

        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTextFiltter.Text))
            {
                dataGridViewUsers.DataSource = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();

                return;
            }

            if (CPoxFilterBy.SelectedItem.ToString() != "None")
            {
                CbIsActive.Visible = false;
                if (CPoxFilterBy.SelectedItem.ToString() == "system_user_id" || CPoxFilterBy.SelectedItem.ToString() == "User_ID")
                {
                    if (int.TryParse(tbTextFiltter.Text, out int ageFilter))
                    {
                        DataTable usersTable = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();
                        DataView dv = new DataView(usersTable);
                        dv.RowFilter = $"{CPoxFilterBy.SelectedItem} = {ageFilter}";
                        dataGridViewUsers.DataSource = dv;
                    }
                    else
                    {
                        tbTextFiltter.Text = tbTextFiltter.Text.Remove(tbTextFiltter.Text.Length - 1);
                        return;
                    }

                }

            }
        }

        private void DataGridViewUsers_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (usersTable == null || e.ColumnIndex < 0)
                return;

            string columnName = dataGridViewUsers.Columns[e.ColumnIndex].DataPropertyName;

            if (string.Equals(currentSortColumn, columnName, StringComparison.OrdinalIgnoreCase))
            {
                currentSortDirection = currentSortDirection == ListSortDirection.Ascending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }
            else
            {
                currentSortColumn = columnName;
                currentSortDirection = ListSortDirection.Ascending;
            }

            usersTable.DefaultView.Sort = $"{columnName} {(currentSortDirection == ListSortDirection.Ascending ? "ASC" : "DESC")}";
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemUserInfoForm systemUserInfoForm = new SystemUserInfoForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["System_User_ID"].Value));
            systemUserInfoForm.ShowDialog();
        }

        private void CbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbIsActive.SelectedItem == "All")
            {
                dataGridViewUsers.DataSource = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();
            }
            else if (CbIsActive.SelectedItem == "True")
            {
                DataTable usersTable = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();
                DataView dv = new DataView(usersTable);
                dv.RowFilter = $"{CPoxFilterBy.SelectedItem} = True";
                dataGridViewUsers.DataSource = dv;
            }
            else if (CbIsActive.SelectedItem == "False")
            {
                DataTable usersTable = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUsers();
                DataView dv = new DataView(usersTable);
                dv.RowFilter = $"{CPoxFilterBy.SelectedItem} = False";
                dataGridViewUsers.DataSource = dv;
            }


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdateSystemUserForm updateUserForm = new AddOrUpdateSystemUserForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["System_User_ID"].Value));
            updateUserForm.ShowDialog();
            fillUsersDataGridView();
        }

        private void dataGridViewUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordSystemUserForm changePasswordSystemUserForm = new ChangePasswordSystemUserForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["System_User_ID"].Value));
            changePasswordSystemUserForm.ShowDialog();
        }
    }
}
