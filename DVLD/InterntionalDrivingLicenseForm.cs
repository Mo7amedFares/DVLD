using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class InterntionalDrivingLicenseForm : Form
    {
        public InterntionalDrivingLicenseForm()
        {
            InitializeComponent();
            LoadCPoxFilter();
            LoadWithFilter("1=1");

        }


        void LoadCPoxFilter()
        {
            CPoxFilterBy.Items.Add("None");
            CPoxFilterBy.Items.Add("InternationalLicenseID");
            CPoxFilterBy.Items.Add("RequestID");
            CPoxFilterBy.Items.Add("DriverID");
            CPoxFilterBy.Items.Add("Is_Active");
            CPoxFilterBy.SelectedIndex = 0;

        }

        void LoadWithFilter(string StringFilter)
        {
            DataTable dt = DVLD_DataAccessLayer.InterntionalDrivingLicenseRepository.GetAllInterntionalLicenseDriving();
            DataView dv = new DataView(dt);
            dt.DefaultView.RowFilter = StringFilter;
            dataGridViewRequestLocalDrivaingLicense.DataSource = dv;
        }

        private void tbTextFiltter_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTextFiltter, string.Empty);
            if (tbTextFiltter.Text == string.Empty || CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                LoadWithFilter("1=1");
                return;
            }

            if (!int.TryParse(tbTextFiltter.Text, out _))
            {
                tbTextFiltter.Text = tbTextFiltter.Text.Remove(tbTextFiltter.Text.Length - 1);
                errorProvider1.SetError(tbTextFiltter, "Please enter a valid number");
                return;
            }
            else
            {
                LoadWithFilter($"{CPoxFilterBy.SelectedItem} = {tbTextFiltter.Text}");
                return;
            }

        }

        private void CPoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CPoxFilterBy.SelectedItem == null || CPoxFilterBy.SelectedItem.ToString() == "None")
            {
                tbTextFiltter.Visible = false;
                LoadWithFilter("1=1");
            }
            else
            {
                tbTextFiltter.Visible = true;
            }
        }

        private void BtnAddNewLocalLicense_Click(object sender, EventArgs e)
        {
            NewInterntionalDrivingLicenseForm newInterntionalDrivingLicenseForm = new NewInterntionalDrivingLicenseForm();
            newInterntionalDrivingLicenseForm.ShowDialog();
        }

        private void showLocalDrivingLiceseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterntionalDrivaingLicenseInfoForm interntionalDrivaingLicenseInfoForm = new InterntionalDrivaingLicenseInfoForm(Convert.ToInt32(dataGridViewRequestLocalDrivaingLicense.CurrentRow.Cells["InternationalLicenseID"].Value));
            interntionalDrivaingLicenseInfoForm.ShowDialog();
        }

        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadWithFilter("1=1");
        }

        private void addLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInterntionalDrivingLicenseForm newInterntionalDrivingLicenseForm = new NewInterntionalDrivingLicenseForm();
            newInterntionalDrivingLicenseForm.ShowDialog();
            LoadWithFilter("1=1");
        }
    }
}
