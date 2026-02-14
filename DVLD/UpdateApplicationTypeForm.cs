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
    public partial class UpdateApplicationTypeForm : Form
    {
        private int applicationTypeId;
        public UpdateApplicationTypeForm(int id)
        {
            InitializeComponent();
            applicationTypeId = id;
            LoadApplicationTypeDetails();
        }

        private void LoadApplicationTypeDetails()
        {
            if (applicationTypeId == -1)
            {
                return;
            }
            ApplicationTypesService applicationTypesService = new ApplicationTypesService();
            applicationTypesService.GetApplicationTypeById(applicationTypeId);
            lblAppID.Text = applicationTypesService.ID.ToString();
            tbAppName.Text = applicationTypesService.Name;
            tbAppFees.Text = applicationTypesService.Fees.ToString();

        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DVLD_BusinessLogicLayer.ApplicationTypesService.UpdateApplicationType(applicationTypeId, tbAppName.Text, Convert.ToDecimal(tbAppFees.Text)))
            {
                MessageBox.Show("Application Type updated successfully.");
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update Application Type. Please try again.");
            }
        }
    }
}
