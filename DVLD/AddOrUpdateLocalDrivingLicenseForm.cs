using DVLD;
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
    public partial class AddOrUpdateLocalDrivingLicenseForm : Form
    {
        int Local_Driving_License_Id = -1;
        int Person_ID = -1;

        DVLD_BusinessLogicLayer.LocalDrivingLicenseService localDrivingLicenseService;
        DVLD_BusinessLogicLayer.ApplicationTypesService applicationTypesService = new();

        public AddOrUpdateLocalDrivingLicenseForm(int Local_Driving_License_Id)
        {
            InitializeComponent();
            this.Local_Driving_License_Id = Local_Driving_License_Id;
            uC_SearchPeoble1.DataBackEvent += (object sender, int id) => Person_ID = id;
            LoadForm();
        }

        void loadLicenseClasses()
        {
            DataTable dt = DVLD_BusinessLogicLayer.LicenseClassService.GetAllIdAndNameLicenseClasses();
            cmbLicenseClass.DisplayMember = "LicenseClassName";
            cmbLicenseClass.ValueMember = "License_Class_ID";
            cmbLicenseClass.DataSource = dt;
        }



        void LoadRequestData()
        {
            if (Local_Driving_License_Id >0)
            {
                localDrivingLicenseService = new DVLD_BusinessLogicLayer.LocalDrivingLicenseService(Local_Driving_License_Id);
                if (localDrivingLicenseService != null)
                {
                    lblAddOrUpdateSystemUser.Text = "Update Local Driving License Request";
                    lblApplicationID.Text = localDrivingLicenseService.Request_id.ToString();
                    Person_ID = localDrivingLicenseService.user_id;
                    uC_SearchPeoble1.LoadData(Person_ID);
                    cmbLicenseClass.SelectedValue = localDrivingLicenseService.License_Class_ID;
                    lblApplicationDate.Text = localDrivingLicenseService.Date.ToShortDateString();
                    lblLastStatusDate.Text = localDrivingLicenseService.LastStatusDate.ToShortDateString();
                    lblApplicationFees.Text = localDrivingLicenseService.PaidFees.ToString("C");
                    lblCreatedBy.Text = SystemUserService.GetUsernameById(localDrivingLicenseService.created_by_system_user);
                    tabPage1.Enabled = false; // Disable editing for existing requests

                }
                else
                {
                    MessageBox.Show("Failed to load Local Driving License request data.");
                    this.Close();
                }
            }
            else
            {
                tabPage2.Enabled = false;
                btnSave.Enabled = false;
                lblCreatedBy.Text = MainForm.curentLonginSystemUser.Username;
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblLastStatusDate.Text = DateTime.Now.ToShortDateString();

                applicationTypesService.GetApplicationTypeById(1); // Assuming 1 is the ID for local driving license application
                cmbLicenseClass.SelectedIndex = 0; // Set default license class
                lblApplicationFees.Text = applicationTypesService.Fees.ToString("C");
            }
        }

        void LoadForm()
        {
            loadLicenseClasses();
            LoadRequestData();
        }


        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (Person_ID == -1)
            {
                MessageBox.Show("Please select a person before proceeding.");
                return;
            }
            tabPage2.Enabled = true;
            btnSave.Enabled = true;
            tabLocalLicense.SelectedTab = tabPage2;

            tabPage1.Enabled = false;

        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Local_Driving_License_Id == -1)
            {
                localDrivingLicenseService = new DVLD_BusinessLogicLayer.LocalDrivingLicenseService(null, Person_ID, DateTime.Now, DateTime.Now, DVLD_BusinessLogicLayer.RequestService.enState.New, MainForm.curentLonginSystemUser.User_ID, applicationTypesService.Fees, Convert.ToInt32(cmbLicenseClass.SelectedValue));
                if (localDrivingLicenseService.isAlreadyHaveSameClassLicense())
                {
                    MessageBox.Show("The person already has a license of the same class. Cannot submit duplicate request.", "Duplicate License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (localDrivingLicenseService.Save())
                {
                    MessageBox.Show("Local Driving License request added successfully.");
                    this.Local_Driving_License_Id = localDrivingLicenseService.Local_Driving_License_Id; // Get the generated Local_Driving_License_Id
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Failed to add Local Driving License request.");
                }
            }
            else
            {
                localDrivingLicenseService = new DVLD_BusinessLogicLayer.LocalDrivingLicenseService(Local_Driving_License_Id, null, Person_ID, DateTime.Now, DateTime.Now, DVLD_BusinessLogicLayer.RequestService.enState.New, MainForm.curentLonginSystemUser.User_ID, applicationTypesService.Fees, Convert.ToInt32(cmbLicenseClass.SelectedValue));
                if (localDrivingLicenseService.isAlreadyHaveSameClassLicense())
                {
                    MessageBox.Show("The person already has a license of the same class. Cannot submit duplicate request.", "Duplicate License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (localDrivingLicenseService.Save())
                {
                    MessageBox.Show("Local Driving License request updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Local Driving License request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
