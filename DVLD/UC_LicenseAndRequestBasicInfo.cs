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
    public partial class UC_LicenseAndRequestBasicInfo : UserControl
    {
        DVLD_BusinessLogicLayer.LocalDrivingLicenseService localDrivingLicenseService;
        private int _localDrivingLicenseID;
        private int _TestTypeID;
        public UC_LicenseAndRequestBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int localDrivingLicenseID, int TestType)
        {
            localDrivingLicenseService = new(localDrivingLicenseID);
            _localDrivingLicenseID = localDrivingLicenseID;
            _TestTypeID = TestType;
            dataGridView1.DataSource = DVLD_BusinessLogicLayer.TestAppointmentService.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(localDrivingLicenseID, TestType);

            lblLicenseDriveAppID.Text = localDrivingLicenseService.Local_Driving_License_Id.ToString();
            lblAppliedForLicense.Text = LicenseClassService.GetClassNameByID(localDrivingLicenseService.License_Class_ID);
            int PassedTestsCount = DVLD_BusinessLogicLayer.TestAppointmentService.GetCountOfTestAppointmentsByLicenseDriveID(localDrivingLicenseService.Local_Driving_License_Id);
            lblPassedTest.Text = $"{PassedTestsCount}/3";
            lblkShowLicenseInfo.Enabled = (PassedTestsCount==3);
            uS_ApplicationBaseInfo1.LoadData(localDrivingLicenseService.Request_id);
        }

        private void BtnAddNewTestAppointment_Click(object sender, EventArgs e)
        {

            if (DVLD_BusinessLogicLayer.TestAppointmentService.doseTestAppointmentIsNotCompleted(_localDrivingLicenseID, _TestTypeID))
            {
                MessageBox.Show("You have an ongoing test appointment. Please complete it before scheduling a new one.");
                return;
            }

            if (DVLD_BusinessLogicLayer.TestAppointmentService.doseTestAppointmentIsCompletedAndPassed(_localDrivingLicenseID, _TestTypeID))
            {
                MessageBox.Show("Congratulations! You have already passed the vision test. No need to schedule another appointment.");
                return;
            }

            AddOrUpdateTestVistionForm addOrUpdateForm = new AddOrUpdateTestVistionForm(_localDrivingLicenseID, _TestTypeID, -1, dataGridView1.RowCount);
            addOrUpdateForm.ShowDialog();
            dataGridView1.DataSource = DVLD_BusinessLogicLayer.TestAppointmentService.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(_localDrivingLicenseID, _TestTypeID);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["IsCompleted"].Value.ToString() == "True")
            {
                MessageBox.Show("This test appointment has already been completed. Please select another appointment.");
                return;
            }
            TakeTest takeTestForm = new TakeTest(int.Parse(dataGridView1.CurrentRow.Cells["AppointmentID"].Value.ToString()), dataGridView1.RowCount);
            takeTestForm.ShowDialog();
            LoadData(_localDrivingLicenseID, _TestTypeID);
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(dataGridView1.CurrentRow.Cells["IsCompleted"].Value.ToString()))
            {
                MessageBox.Show("This test appointment has already been completed. You cannot edit a completed appointment.");
                return;
            }
            AddOrUpdateTestVistionForm addOrUpdateForm = new AddOrUpdateTestVistionForm(_localDrivingLicenseID, _TestTypeID, int.Parse(dataGridView1.CurrentRow.Cells["AppointmentID"].Value.ToString()), dataGridView1.RowCount);
            addOrUpdateForm.ShowDialog();
            dataGridView1.DataSource = DVLD_BusinessLogicLayer.TestAppointmentService.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(_localDrivingLicenseID, _TestTypeID);

        }
    }
}
