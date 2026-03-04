using DVLD_BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class UC_LicenseAndRequestBasicInfo : UserControl
    {
        DVLD_BusinessLogicLayer.LocalDrivingLicenseService localDrivingLicenseService;
        public UC_LicenseAndRequestBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int localDrivingLicenseID)
        {
            localDrivingLicenseService = new(localDrivingLicenseID);

            lblLicenseDriveAppID.Text = localDrivingLicenseService.Local_Driving_License_Id.ToString();
            lblAppliedForLicense.Text = LicenseClassService.GetClassNameByID(localDrivingLicenseService.License_Class_ID);
            lblPassedTest.Text = $"{DVLD_BusinessLogicLayer.TestAppointmentService.GetCountOfTestAppointmentsByLicenseDriveID(localDrivingLicenseService.Local_Driving_License_Id)}/3";
            uS_ApplicationBaseInfo1.LoadData(localDrivingLicenseService.Request_id);
        }
    }
}
