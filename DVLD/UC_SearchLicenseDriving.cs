using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class UC_SearchLicenseDriving : UserControl
    {
        private int _driverLicenseNumber = -1;

        public delegate void LicenseSearchLoadedHandler(int DrivingLicenseID);
        public event LicenseSearchLoadedHandler LicenseSearchLoaded;
        public UC_SearchLicenseDriving()
        {
            InitializeComponent();
        }


        bool validateInput()
        {
            if (int.TryParse(tbTextFiltter.Text, out _))
            {
                return true;
            }
            else
            {
                errorProvider1.SetError(tbTextFiltter, "Please enter a valid number");
                return false;
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            uC_DriverLicenseInfo1.LicenseInfoLoaded += OnLicenseInfoLoaded;
            _driverLicenseNumber = Convert.ToInt32(tbTextFiltter.Text);
            uC_DriverLicenseInfo1.loadData(_driverLicenseNumber, UC_DriverLicenseInfo.enLoadDataBy.LicenseID);
        }

        private void OnLicenseInfoLoaded(bool isFound)
        {
            if (!isFound)
            {
                errorProvider1.SetError(tbTextFiltter, "Not Found License use this number");
                _driverLicenseNumber = -1;
            }
            LicenseSearchLoaded?.Invoke(_driverLicenseNumber);
           
        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            if (!validateInput()&& !string.IsNullOrEmpty(tbTextFiltter.Text))
            {
                tbTextFiltter.Text = tbTextFiltter.Text.Remove(tbTextFiltter.Text.Length - 1);
            }
        }
    }
}
