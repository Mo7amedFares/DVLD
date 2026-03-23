using DVLD;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class NewInterntionalDrivingLicenseForm : Form
    {
        private int _drivingLicenseID = -1;
        private string _SSN;
        private int RequestID, DriverID, created_by_User_Id, IssuedUsingLocalLicenseID, UserID, licenseClassID;
        private decimal Fees;
        private DateTime ExpirationDate;


        public NewInterntionalDrivingLicenseForm()
        {
            InitializeComponent();
            btnIssue.Enabled = false;
            linklblShowLicenseInfo.Enabled = false;


            uC_SearchLicenseDriving1.LicenseSearchLoaded += OnLicenseSearchLoaded;

            loadData();
        }

        private void OnLicenseSearchLoaded(int drivingLicenseID)
        {
            _drivingLicenseID = drivingLicenseID;
            loadData();
        }

        private void loadData()
        {
            if (_drivingLicenseID == -1)
            {
                linkLblShowLicenseHistory.Enabled = false;
                return;
            }
            if (!DVLD_BusinessLogicLayer.LicenseService.IsActiveLicenseDriveBy(_drivingLicenseID))
            {
                MessageBox.Show("This License is  Not Active please Enter anther License ID");
                return;
            }

            DataRow dt = DVLD_BusinessLogicLayer.InterntionalDrivingLicenseService
                .GetApplicationInfoToNewInterntionalLicenseByLicenseID(_drivingLicenseID);

            if (dt == null) return;
            btnIssue.Enabled = true;

            lblLocalLecenseID.Text = dt["Local_Driving_License_Id"].ToString();
            IssuedUsingLocalLicenseID = Convert.ToInt32(dt["Local_Driving_License_Id"]);
            DriverID = Convert.ToInt32(dt["DriverID"]);
            RequestID = Convert.ToInt32(dt["Request_id"]);
            created_by_User_Id = MainForm.curentLonginSystemUser.System_User_Id;
            Fees = Convert.ToDecimal(dt["Fees"]);
            UserID = Convert.ToInt32(dt["user_id"]);
            licenseClassID = Convert.ToInt32(dt["License_Class_ID"]);

            DateTime issueDate = DateTime.Now;
            ExpirationDate = issueDate.AddYears(DVLD_BusinessLogicLayer.LicenseClassService.GetLicenseClassByID(licenseClassID).ValidityLength);

            lblIssueDate.Text = issueDate.ToShortDateString();
            lblExpertionDate.Text = ExpirationDate.ToShortDateString();
            lblFees.Text = $"{dt["Fees"]:c}";
            lblCreatedBy.Text = MainForm.curentLonginSystemUser.Username;
            _SSN = dt["SSN"].ToString();
            linkLblShowLicenseHistory.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void linkLblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm licenseHistoryForm = new LicenseHistoryForm(_SSN, 2);
            licenseHistoryForm.ShowDialog();
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            DVLD_BusinessLogicLayer.InterntionalDrivingLicenseService interntionalDrivingLicenseService = new DVLD_BusinessLogicLayer.InterntionalDrivingLicenseService(null, UserID, DateTime.Now, DateTime.Now, DVLD_BusinessLogicLayer.RequestService.enState.Completed, MainForm.curentLonginSystemUser.System_User_Id, Fees, licenseClassID, DriverID, IssuedUsingLocalLicenseID, ExpirationDate);

            if (interntionalDrivingLicenseService.AddInterntionalDrivingLicense())
            {
                MessageBox.Show("International Driving License Issued Successfully");
                btnIssue.Enabled = false;
                linklblShowLicenseInfo.Enabled = true;
                lblnterntionalLicenseID.Text = interntionalDrivingLicenseService.InternationalDrivingLicenseID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to Issue International Driving License");
            }
        }

        private void linklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterntionalDrivaingLicenseInfoForm interntionalDrivaingLicenseInfoForm = new InterntionalDrivaingLicenseInfoForm(Convert.ToInt32(lblnterntionalLicenseID.Text));
            interntionalDrivaingLicenseInfoForm.ShowDialog();
        }
    }
}
