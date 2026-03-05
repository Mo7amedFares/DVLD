using DVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class TakeTest : Form
    {
        int _appointmentID;
        int _countTrial;
        public TakeTest(int appointmentID, int CountTrial)
        {
            _appointmentID = appointmentID;
            _countTrial = CountTrial;

            InitializeComponent();
            LoadTest();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void LoadTest()
        {
            DataRow dataRow = DVLD_BusinessLogicLayer.TestAppointmentService.GetDateToTestAppointmentBy(_appointmentID);
            if (dataRow != null)
            {
                lblLicenseDriveAppID.Text = dataRow["LocalDrivingLicenseID"].ToString();
                lblFullName.Text = dataRow["FullName"].ToString();
                lblLicenseClass.Text = dataRow["LicenseClassName"].ToString();
                lblFees.Text = dataRow["Payed_Test"].ToString();
                lblDate.Text = Convert.ToDateTime(dataRow["AppointmentDate"]).ToString("yyyy-MM-dd");
                lblTrial.Text = _countTrial.ToString();

            }
            else
            {
                MessageBox.Show("No data found for the given appointment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DVLD_BusinessLogicLayer.TestAppointmentService.TakeTestAppointment(_appointmentID, rbPass.Checked, MainForm.curentLonginSystemUser.System_User_Id, textBox1.Text))
            {
                MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Failed to save test result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
