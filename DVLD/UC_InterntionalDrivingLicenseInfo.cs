using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DVLD_Persntation.UC_DriverLicenseInfo;

namespace DVLD_Persntation
{
    public partial class UC_InterntionalDrivingLicenseInfo : UserControl
    {
        public UC_InterntionalDrivingLicenseInfo()
        {
            InitializeComponent();
        }
        public delegate void LicenseInfoLoadedHandler(bool isFound);
        public event LicenseInfoLoadedHandler LicenseInfoLoaded;

        public void loadData(int ID)
        {
            DataRow InterntionalLicenseInfo = DVLD_BusinessLogicLayer.InterntionalDrivingLicenseService.GetInterntionalDrivingLicenseByID(ID);

            bool isFound = (InterntionalLicenseInfo != null);
            LicenseInfoLoaded?.Invoke(isFound);

            if (!isFound)
                return;

            //Full Name   InternationalLicenseID RequestID   LicenseID SSN Gender IssueDate   ExpirationDate DriverID    Date_Of_Birth Is_Active

            lblName.Text = InterntionalLicenseInfo["Full Name"].ToString();
            lblLecenseID.Text = InterntionalLicenseInfo["LicenseID"].ToString();
            lblSSN.Text = InterntionalLicenseInfo["SSN"].ToString();
            lblGendor.Text = InterntionalLicenseInfo["Gender"].ToString();
            lblIssueDate.Text = ((DateTime)InterntionalLicenseInfo["IssueDate"]).ToShortDateString();
            lblIsActive.Text = InterntionalLicenseInfo["Is_Active"].ToString();
            lblBirthOfDate.Text = ((DateTime)InterntionalLicenseInfo["Date_Of_Birth"]).ToShortDateString();
            lblDriverID.Text = InterntionalLicenseInfo["DriverID"].ToString();
            lblExpertionDate.Text = ((DateTime)InterntionalLicenseInfo["ExpirationDate"]).ToShortDateString();
            lblIntLiceseID.Text = InterntionalLicenseInfo["InternationalLicenseID"].ToString();
            lblRequestID.Text = InterntionalLicenseInfo["RequestID"].ToString();

            if (InterntionalLicenseInfo["Profile_Photo_URL"] != DBNull.Value)
            {
                string photoUrl = InterntionalLicenseInfo["Profile_Photo_URL"].ToString();
                try
                {
                    PbImage.Load(photoUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading profile photo: {ex.Message}");
                }
            }
        }
    }
}
