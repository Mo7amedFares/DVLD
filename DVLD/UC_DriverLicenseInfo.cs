using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class UC_DriverLicenseInfo : UserControl
    {
        public enum enLoadDataBy { LicenseID, LocalDrivingLicenseID }

        public delegate void LicenseInfoLoadedHandler(bool isFound);
        public event LicenseInfoLoadedHandler LicenseInfoLoaded;

        public UC_DriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void loadData(int ID, enLoadDataBy loadDataBy)
        {
            DataRow licenseInfo;
            if (loadDataBy == enLoadDataBy.LocalDrivingLicenseID)
                licenseInfo = DVLD_BusinessLogicLayer.LicenseService.GetDriverLicenseInfoByLocalDrivingLicenseID(ID);
            else
                licenseInfo = DVLD_BusinessLogicLayer.LicenseService.GetDriverLicenseInfoByLicenseID(ID);

            bool isFound = (licenseInfo != null);
            LicenseInfoLoaded?.Invoke(isFound);

            if (!isFound)
                return;

            // LicenseClassName Full Name LicenseID SSN Gender IssueDate Notes IsActive Date_Of_Birth DriverID ExpirationDate Profile_Photo_URL
            lblClass.Text = licenseInfo["LicenseClassName"].ToString();
            lblName.Text = licenseInfo["Full Name"].ToString();
            lblLecenseID.Text = licenseInfo["LicenseID"].ToString();
            lblSSN.Text = licenseInfo["SSN"].ToString();
            lblGendor.Text = licenseInfo["Gender"].ToString();
            lblIssueDate.Text = ((DateTime)licenseInfo["IssueDate"]).ToShortDateString();
            lblNote.Text = licenseInfo["Notes"].ToString();
            lblIsActive.Text = licenseInfo["IsActive"].ToString();
            lblBirthOfDate.Text = ((DateTime)licenseInfo["Date_Of_Birth"]).ToShortDateString();
            lblDriverID.Text = licenseInfo["DriverID"].ToString();
            lblExpertionDate.Text = ((DateTime)licenseInfo["ExpirationDate"]).ToShortDateString();

            if (licenseInfo["Profile_Photo_URL"] != DBNull.Value)
            {
                string photoUrl = licenseInfo["Profile_Photo_URL"].ToString();
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