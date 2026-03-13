using DVLD;
using DVLD_BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class IssueDrivingLicenseForTheFirstTimeForm : Form
    {
        private readonly int _localDrivingLicenseID;
        private LocalDrivingLicenseService _localDrivingLicenseService;

        public IssueDrivingLicenseForTheFirstTimeForm(int localDrivingLicenseID)
        {
            InitializeComponent();
            _localDrivingLicenseID = localDrivingLicenseID;
        }

        private void IssueDrivingLicenseForTheFirstTimeForm_Load(object sender, EventArgs e)
        {
            _localDrivingLicenseService = new LocalDrivingLicenseService(_localDrivingLicenseID);
            uC_LicenseAndRequestBasicInfo1.LoadData(_localDrivingLicenseID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure you want to issue this driving license?",
                    "Confirm Issue",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            int newLicenseID = LicenseService.IssueFirstTimeLicense(
                _localDrivingLicenseService,
                txNote.Text.Trim(),
                MainForm.curentLonginSystemUser.System_User_Id);

            if (newLicenseID > 0)
            {
                MessageBox.Show(
                    $"License issued successfully!\nLicense ID: {newLicenseID}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Failed to issue license. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
