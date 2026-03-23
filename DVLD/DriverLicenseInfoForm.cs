using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class DriverLicenseInfoForm : Form
    {
        public DriverLicenseInfoForm(int LocalDrivingLicenseID)
        {
            InitializeComponent();

            uC_DriverLicenseInfo1.LicenseInfoLoaded += OnLicenseInfoLoaded;
            uC_DriverLicenseInfo1.loadData(LocalDrivingLicenseID, UC_DriverLicenseInfo.enLoadDataBy.LocalDrivingLicenseID);
        }

        private void OnLicenseInfoLoaded(bool isFound)
        {
            if (!isFound)
            {
                MessageBox.Show("License info not found.");
            }
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}