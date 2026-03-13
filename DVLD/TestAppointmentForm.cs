using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD_Persntation
{
    public partial class TestAppointmentForm : Form
    {
        int _localDrivingLicenseID;
        int _TestTypeID;
        public TestAppointmentForm(int LocalDrivingLicenseID, int TestType)
        {
            InitializeComponent();
            _localDrivingLicenseID = LocalDrivingLicenseID;
            _TestTypeID = TestType;
            setImage();
            uC_LicenseAndRequestBasicInfo1.LoadData(_localDrivingLicenseID);
            loadDataGridView();
        }

        void loadDataGridView()
        {
            dataGridView1.DataSource = DVLD_BusinessLogicLayer.TestAppointmentService.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(_localDrivingLicenseID, _TestTypeID);
        }
        void setImage()
        {
            if (_TestTypeID == 1)
            {
                pictureBox1.Image = Properties.Resources.eye;
                lblAddOrUpdateSystemUser.Text = "Vision Test Appointmetn";
            }
            else if (_TestTypeID == 2)
            {
                pictureBox1.Image = Properties.Resources.vintage_writing;
                lblAddOrUpdateSystemUser.Text = "Writing Test Appointmetn";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.driving_test;
                lblAddOrUpdateSystemUser.Text = "Driving Test Appointmetn";
            }
        }
        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
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
            loadDataGridView();
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
            uC_LicenseAndRequestBasicInfo1.LoadData(_localDrivingLicenseID);
            loadDataGridView();
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
            loadDataGridView();

        }
    }

}
