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
        private int _localDrivingLicenseID;
        private int _TestTypeID;
        public UC_LicenseAndRequestBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int localDrivingLicenseID)
        {
            localDrivingLicenseService = new(localDrivingLicenseID);
            _localDrivingLicenseID = localDrivingLicenseID;

            lblLicenseDriveAppID.Text = localDrivingLicenseService.Local_Driving_License_Id.ToString();
            lblAppliedForLicense.Text = LicenseClassService.GetClassNameByID(localDrivingLicenseService.License_Class_ID);
            int PassedTestsCount = DVLD_BusinessLogicLayer.TestAppointmentService.GetCountOfTestAppointmentsByLicenseDriveID(localDrivingLicenseService.Local_Driving_License_Id);
            lblPassedTest.Text = $"{PassedTestsCount}/3";
            lblkShowLicenseInfo.Enabled = (PassedTestsCount==3);
            uS_ApplicationBaseInfo1.LoadData(localDrivingLicenseService.Request_id);
        }


    }
}
