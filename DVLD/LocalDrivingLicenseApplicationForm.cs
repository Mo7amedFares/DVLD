using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class LocalDrivingLicenseApplicationForm : Form
    {
        public LocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
            dataGridViewRequestLocalDrivaingLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadCPoxFilter();

        }

        void LoadCPoxFilter()
        {
            CPoxFilterBy.Items.Add("None");
            CPoxFilterBy.Items.Add("Request_id");
            CPoxFilterBy.Items.Add("user_id");
            CPoxFilterBy.Items.Add("StateName");
            CPoxFilterBy.Items.Add("Name");
            CPoxFilterBy.SelectedIndex = 0;
            CPoxFilterBy_SelectedIndexChanged(null, null);

        }



        void LoadWithFilter(string StringFilter)
        {
            DataTable dt = DVLD_BusinessLogicLayer.LocalDrivingLicenseService.GetAllRequestLocalDrivingLicense();

            if (!dt.Columns.Contains("StateName"))
            {
                dt.Columns.Add("StateName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    var stateValue = row["State"] is int v ? v : 0;
                    row["StateName"] = Enum.GetName(typeof(DVLD_BusinessLogicLayer.RequestService.enState), stateValue) ?? "Unknown";
                }
            }

            dt.DefaultView.RowFilter = StringFilter;
            dataGridViewRequestLocalDrivaingLicense.DataSource = dt;

            dataGridViewRequestLocalDrivaingLicense.Columns["State"].Visible = false;
            dataGridViewRequestLocalDrivaingLicense.Columns["StateName"].HeaderText = "State";
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddNewLocalLicense_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicenseForm addForm = new AddOrUpdateLocalDrivingLicenseForm(-1);
            addForm.ShowDialog();
        }

        private void addLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicenseForm addForm = new AddOrUpdateLocalDrivingLicenseForm(-1);
            addForm.ShowDialog();
        }

        private void showLocalDrivingLiceseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicenseForm editForm = new AddOrUpdateLocalDrivingLicenseForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Request_ID"].Value));
            editForm.ShowDialog();
        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            if(CPoxFilterBy.SelectedItem == null || CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                LoadWithFilter("1=1");
                return;
            }

            if (CPoxFilterBy.SelectedItem == "Request_id" || CPoxFilterBy.SelectedItem == "user_id")
            {
                if (!int.TryParse(tbTextFiltter.Text, out _))
                {
                    tbTextFiltter.Text = tbTextFiltter.Text.Remove(tbTextFiltter.Text.Length - 1);
                    errorProvider1.SetError(tbTextFiltter, "Please enter a valid number");
                    return;
                }
                else
                {
                    LoadWithFilter($"{CPoxFilterBy.SelectedItem} = {tbTextFiltter.Text}");
                    return;
                }
            }
            LoadWithFilter($"{CPoxFilterBy.SelectedItem} LIKE '%{tbTextFiltter.Text}%'");


        }
        private void CPoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CPoxFilterBy.SelectedItem == null || CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                tbTextFiltter.Visible = false;
                LoadWithFilter("1=1");
            }
            else
            {
                tbTextFiltter.Visible = true;
            }
        }

        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            refrechToolStripMenuItem_Click(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVLD_BusinessLogicLayer.LocalDrivingLicenseService localDrivingLicenseService = new DVLD_BusinessLogicLayer.LocalDrivingLicenseService(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Request_ID"].Value));
            localDrivingLicenseService.State = (int)DVLD_BusinessLogicLayer.RequestService.enState.cancelled;
            localDrivingLicenseService.ChangeRequestState();
            refrechToolStripMenuItem_Click(null , null);
        }

     
    }
}
