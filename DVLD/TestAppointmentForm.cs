using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            uC_LicenseAndRequestBasicInfo1.LoadData(_localDrivingLicenseID, _TestTypeID);
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

        private void uC_LicenseAndRequestBasicInfo1_Load(object sender, EventArgs e)
        {

        }
    }

}
