using DVLD_BusinessLogicLayer;
using DVLD_Persntation;
using System.ComponentModel;
using System.Data;

namespace DVLD
{
    public partial class MangePeopleForm : Form
    {
        private DataTable usersTable;
        private string currentSortColumn;
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;

        public MangePeopleForm()
        {
            InitializeComponent();
            AddItemsToFilterByComboBox();
            fillUsersDataGridView();
            dataGridViewUsers.ColumnHeaderMouseClick += DataGridViewUsers_ColumnHeaderMouseClick;

        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            NewOrUpdateUserForm newUserForm = new NewOrUpdateUserForm(-1);
            newUserForm.ShowDialog();
            fillUsersDataGridView();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // If this was the active child, clear it
            if (MainForm.currentChildForm == this)
                MainForm.currentChildForm = null;
        }

        private void fillUsersDataGridView()
        {
            DVLD_BusinessLogicLayer.UserService userService = new DVLD_BusinessLogicLayer.UserService();
            dataGridViewUsers.DataSource = userService.GetUsers();
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrUpdateUserForm updateUserForm = new NewOrUpdateUserForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["User_ID"].Value));
            updateUserForm.ShowDialog();
            fillUsersDataGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserService.Delete(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["User_ID"].Value));
            fillUsersDataGridView();
        }

        private void addPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrUpdateUserForm newUserForm = new NewOrUpdateUserForm(-1);
            newUserForm.ShowDialog();
            fillUsersDataGridView();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillUsersDataGridView();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfoForm personInfoForm = new PersonInfoForm(Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["User_ID"].Value));
            personInfoForm.ShowDialog();
        }

        private void AddItemsToFilterByComboBox()
        {
            CPoxFilterBy.Items.Add("None");
            // Add other filter options as needed
            CPoxFilterBy.Items.Add("User_ID");
            CPoxFilterBy.Items.Add("First_Name");
            CPoxFilterBy.Items.Add("Second_Name");
            CPoxFilterBy.Items.Add("Third_Name");
            CPoxFilterBy.Items.Add("Last_Name");
            CPoxFilterBy.Items.Add("Age");
            CPoxFilterBy.Items.Add("Gender");
            CPoxFilterBy.Items.Add("Email");
            CPoxFilterBy.Items.Add("Phone");
            CPoxFilterBy.Items.Add("Address");
            CPoxFilterBy.Items.Add("Nationality");
            CPoxFilterBy.Items.Add("SSN");
            CPoxFilterBy.SelectedIndex = 0; // Set default selection
        }
        private void CPoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example filter implementation
            DVLD_BusinessLogicLayer.UserService userService = new DVLD_BusinessLogicLayer.UserService();
            DataTable usersTable;
            // add downList filter options

            if (CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                dataGridViewUsers.DataSource = userService.GetUsers();
                tbTextFiltter.Hide();

            }
            else
            {

                tbTextFiltter.Show();
            }

        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTextFiltter.Text))
            {
                DVLD_BusinessLogicLayer.UserService userService = new DVLD_BusinessLogicLayer.UserService();
                dataGridViewUsers.DataSource = userService.GetUsers();
                return;
            }

            if (CPoxFilterBy.SelectedItem.ToString() != "None")
            {
                if (CPoxFilterBy.SelectedItem.ToString() == "Age" || CPoxFilterBy.SelectedItem.ToString() == "User_ID")
                {
                    if (int.TryParse(tbTextFiltter.Text, out int ageFilter))
                    {
                        DVLD_BusinessLogicLayer.UserService userService = new DVLD_BusinessLogicLayer.UserService();
                        DataTable usersTable = userService.GetUsers();
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
                else
                {

                    DVLD_BusinessLogicLayer.UserService userService = new DVLD_BusinessLogicLayer.UserService();
                    DataTable usersTable = userService.GetUsers();
                    DataView dv = new DataView(usersTable);
                    dv.RowFilter = $"{CPoxFilterBy.SelectedItem} LIKE '%{tbTextFiltter.Text}%'";
                    dataGridViewUsers.DataSource = dv;
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

    }
}

