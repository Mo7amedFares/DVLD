using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class VistionTestAppointmentForm : Form
    {
        int _localDrivingLicenseID;
        public VistionTestAppointmentForm(int id)
        {
            InitializeComponent();
            _localDrivingLicenseID = id;
            uC_LicenseAndRequestBasicInfo1.LoadData(id);
            dataGridView1.DataSource = DVLD_BusinessLogicLayer.TestAppointmentService.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(id, 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddNewTestAppointment_Click(object sender, EventArgs e)
        {
            if (DVLD_BusinessLogicLayer.TestAppointmentService.doseTestAppointmentIsNotCompleted(_localDrivingLicenseID, 1))
            {
                MessageBox.Show("You have an ongoing test appointment. Please complete it before scheduling a new one.");
                return;
            }

            if (DVLD_BusinessLogicLayer.TestAppointmentService.doseTestAppointmentIsCompletedAndPassed(_localDrivingLicenseID, 1))
            {
                MessageBox.Show("Congratulations! You have already passed the vision test. No need to schedule another appointment.");
                return;
            }

            AddOrUpdateTestVistionForm addOrUpdateForm = new AddOrUpdateTestVistionForm(_localDrivingLicenseID, 1, -1, dataGridView1.RowCount);
            addOrUpdateForm.ShowDialog();
            dataGridView1.DataSource = DVLD_BusinessLogicLayer.TestAppointmentService.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(_localDrivingLicenseID, 1);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (dataGridView1.CurrentRow.Cells["IsCompleted"].Value.ToString()=="True")
                {
                    MessageBox.Show("This test appointment has already been completed. Please select another appointment.");
                    return;
                }
            TakeTest takeTestForm = new TakeTest(int.Parse(dataGridView1.CurrentRow.Cells["AppointmentID"].Value.ToString()), dataGridView1.RowCount);
            takeTestForm.ShowDialog();
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bool.Parse(dataGridView1.CurrentRow.Cells["IsCompleted"].Value.ToString()) )
            {
                MessageBox.Show("This test appointment has already been completed. You cannot edit a completed appointment.");
                return;
            }
            AddOrUpdateTestVistionForm addOrUpdateForm = new AddOrUpdateTestVistionForm(_localDrivingLicenseID, 1, int.Parse(dataGridView1.CurrentRow.Cells["AppointmentID"].Value.ToString()), dataGridView1.RowCount);
            addOrUpdateForm.ShowDialog();
        }
    }
}
