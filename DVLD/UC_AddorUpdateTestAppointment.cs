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
    public partial class UC_AddorUpdateTestAppointment : UserControl
    {
        int _localDrivingLicenseID;
        int _localTestAppointmentID = -1;
        int _TestTypeID;
        int _CountTrial;
        public UC_AddorUpdateTestAppointment()
        {
            InitializeComponent();

        }
        public void SetData(int LocalDrivingLicenseID, int TestTypeID, int LocalTestAppointmentID, int CountTrial)
        {
            _localDrivingLicenseID = LocalDrivingLicenseID;
            _TestTypeID = TestTypeID;
            _localTestAppointmentID = LocalTestAppointmentID;
            _CountTrial = CountTrial;
            setImage();
            if (_localTestAppointmentID == -1)
            {
                LoadAddData();
            }
            else
            {
                LoadUpdateData();
            }
        }

        void setImage()
        {
            if (_TestTypeID == 1)
            {
                pictureBox1.Image = Properties.Resources.eye;
                groupBox1.Text = "Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                pictureBox1.Image = Properties.Resources.vintage_writing;
                groupBox1.Text = "Writing Test";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.driving_test;
                groupBox1.Text = "Driving Test";
            }
        }
        private void   LoadAddData()
        {
            DataRow dataRow = DVLD_BusinessLogicLayer.TestAppointmentService.GetDateToAddTestAppointmentBy(_localDrivingLicenseID, _TestTypeID);
            if (dataRow != null)
            {
                lblLicenseDriveAppID.Text = dataRow["Local_Driving_License_Id"].ToString();
                lblFullName.Text = dataRow["FullName"].ToString();
                lblLicenseClass.Text = dataRow["LicenseClassName"].ToString();
                //lblHederTest.Text = $"Add {dataRow["TestTypeName"].ToString()}";
                lblFees.Text = dataRow["Fees"].ToString();
                lblTotalFees.Text = lblFees.Text;
                if (_CountTrial > 0)
                {
                    //lblHederTest.Text = $"Add {dataRow["TestTypeName"].ToString()} - Trial {_CountTrial + 1}";
                    groupBox2.Visible = true;
                    lblRAppFees.Text = "5";
                    lblTotalFees.Text = (decimal.Parse(lblFees.Text) + decimal.Parse(lblRAppFees.Text)).ToString();
                }
                else
                {
                    groupBox2.Visible = false;
                }
            }
        }

        private void LoadUpdateData()
        {
            DataRow dataRow = DVLD_BusinessLogicLayer.TestAppointmentService.GetDateToTestAppointmentBy(_localTestAppointmentID);
            if (dataRow != null)
            {
                lblLicenseDriveAppID.Text = dataRow["LocalDrivingLicenseID"].ToString();
                lblFullName.Text = dataRow["FullName"].ToString();
                lblLicenseClass.Text = dataRow["LicenseClassName"].ToString();
                //"FullName\tLocalDrivingLicenseID\tAppointmentDate\tLicenseClassName\tPayed_Test"
                lblFees.Text = dataRow["Payed_Test"].ToString();
                lblHederTest.Text = $"Update {dataRow["TestTypeName"].ToString()}";
                lblTotalFees.Text = lblFees.Text;
                if (_CountTrial > 1)
                {
                    //lblHederTest.Text = $"Update {dataRow["TestTypeName"].ToString()}";
                    groupBox2.Enabled = true;
                    decimal retestFee = 5m;
                    lblRAppFees.Text = retestFee.ToString();
                    decimal totalFees = Convert.ToDecimal(dataRow["Payed_Test"]) + retestFee;
                    lblTotalFees.Text = totalFees.ToString();
                }
                else
                {
                    groupBox2.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_localTestAppointmentID == -1)
            {
                int result = DVLD_BusinessLogicLayer.TestAppointmentService.AddTestAppointment(_localDrivingLicenseID, _TestTypeID, double.Parse(lblTotalFees.Text), 1);
                if (result > 0)
                {
                    MessageBox.Show("Test Appointment Added Successfully");
                    this.ParentForm.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Add Test Appointment");
                }
            }
            else
            {
                bool result = DVLD_BusinessLogicLayer.TestAppointmentService.UpdateTestAppointment(_localTestAppointmentID, dateTimePicker1.Value, MainForm.curentLonginSystemUser.System_User_Id); ;
                if (result)
                {
                    MessageBox.Show("Test Appointment Updated Successfully");
                    this.ParentForm.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Update Test Appointment");
                }
            }
        }
    }
}