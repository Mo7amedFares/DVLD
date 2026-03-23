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
            CPoxFilterBy.Items.Add("Local_Driving_License_Id");
            CPoxFilterBy.Items.Add("SSN");
            CPoxFilterBy.Items.Add("Full Name");
            CPoxFilterBy.Items.Add("StateName");
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
            DriverLicenseInfoForm driverLicenseInfoForm = new DriverLicenseInfoForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value));
            driverLicenseInfoForm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicenseForm editForm = new AddOrUpdateLocalDrivingLicenseForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value));
            editForm.ShowDialog();
        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTextFiltter, string.Empty);
            if (tbTextFiltter.Text == string.Empty || CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                LoadWithFilter("1=1");
                return;
            }

            if (CPoxFilterBy.SelectedItem == "Local_Driving_License_Id")
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

            LoadCPoxFilter();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DVLD_BusinessLogicLayer.LocalDrivingLicenseService localDrivingLicenseService = new DVLD_BusinessLogicLayer.LocalDrivingLicenseService(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value));
            
            refrechToolStripMenuItem_Click(null, null);
        }

        private void sechduleVistionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestAppointmentForm vistionTestAppointmentForm = new TestAppointmentForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value), 1);
            vistionTestAppointmentForm.ShowDialog();
        }

        private void sechduleWritingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestAppointmentForm vistionTestAppointmentForm = new TestAppointmentForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value), 2);
            vistionTestAppointmentForm.ShowDialog();
        }

        private void sechduleDrivingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestAppointmentForm vistionTestAppointmentForm = new TestAppointmentForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value), 3);
            vistionTestAppointmentForm.ShowDialog();
        }

        private void sechdulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (DVLD_BusinessLogicLayer.TestAppointmentService.GetCountOfTestAppointmentsByLicenseDriveID((Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value))))
            {
                case 0:
                    sechduleDrivingTestToolStripMenuItem.Enabled = false;
                    sechduleWritingTestToolStripMenuItem.Enabled = false;
                    sechduleVistionTestToolStripMenuItem.Enabled = true;
                    break;
                case 1:
                    sechduleDrivingTestToolStripMenuItem.Enabled = false;
                    sechduleWritingTestToolStripMenuItem.Enabled = true;
                    sechduleVistionTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    sechduleDrivingTestToolStripMenuItem.Enabled = true;
                    sechduleWritingTestToolStripMenuItem.Enabled = false;
                    sechduleVistionTestToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void sechdulToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            switch (DVLD_BusinessLogicLayer.TestAppointmentService.GetCountOfTestAppointmentsByLicenseDriveID((Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value))))
            {
                case 0:
                    sechduleDrivingTestToolStripMenuItem.Enabled = false;
                    sechduleWritingTestToolStripMenuItem.Enabled = false;
                    sechduleVistionTestToolStripMenuItem.Enabled = true;
                    break;
                case 1:
                    sechduleDrivingTestToolStripMenuItem.Enabled = false;
                    sechduleWritingTestToolStripMenuItem.Enabled = true;
                    sechduleVistionTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    sechduleDrivingTestToolStripMenuItem.Enabled = true;
                    sechduleWritingTestToolStripMenuItem.Enabled = false;
                    sechduleVistionTestToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (DVLD_BusinessLogicLayer.TestAppointmentService.GetCountOfTestAppointmentsByLicenseDriveID((Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value))) == 3)
            {
                sechdulToolStripMenuItem.Enabled = false;

                if (LicenseService.ExistLicenseDriveBy(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value)))
                {
                    issueLicenseToolStripMenuItem.Enabled = false;
                    showLocalDrivingLiceseToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = false;
                    editToolStripMenuItem.Enabled = false;
                }
                else
                {
                    showLocalDrivingLiceseToolStripMenuItem.Enabled = false;
                    issueLicenseToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                showLocalDrivingLiceseToolStripMenuItem.Enabled = false;
                sechdulToolStripMenuItem.Enabled = true;
                issueLicenseToolStripMenuItem.Enabled = false;
            }
        }

        private void issueLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseForTheFirstTimeForm issueDrivingLicenseForTheFirstTimeForm = new(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value));
            issueDrivingLicenseForTheFirstTimeForm.ShowDialog();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistoryForm licenseHistoryForm = new LicenseHistoryForm(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["SSN"].Value.ToString(), 1);
            licenseHistoryForm.ShowDialog();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVLD_BusinessLogicLayer.LocalDrivingLicenseService localDrivingLicenseService = new DVLD_BusinessLogicLayer.LocalDrivingLicenseService(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["Local_Driving_License_Id"].Value));
            localDrivingLicenseService.State = (int)DVLD_BusinessLogicLayer.RequestService.enState.cancelled;
            localDrivingLicenseService.ChangeRequestState();
            refrechToolStripMenuItem_Click(null, null);
        }
    }
}