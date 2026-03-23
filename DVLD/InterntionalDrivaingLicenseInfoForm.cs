using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class InterntionalDrivaingLicenseInfoForm : Form
    {
        public InterntionalDrivaingLicenseInfoForm(int id)
        {
            InitializeComponent();
            uC_InterntionalDrivingLicenseInfo1.LicenseInfoLoaded += OnLicenseInfoLoaded;
            uC_InterntionalDrivingLicenseInfo1.loadData(id);
        }

        private void OnLicenseInfoLoaded(bool isFound)
        {
            if(!isFound)
            {
                MessageBox.Show("International Driving License information not found.");
                this.Close();
            }
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
