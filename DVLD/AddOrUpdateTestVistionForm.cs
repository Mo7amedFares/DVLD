using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class AddOrUpdateTestVistionForm : Form
    {
        public AddOrUpdateTestVistionForm(int LocalDrivingLicenseID, int TestTypeID, int LocalTestAppointmentID, int CountTrial)
        {
            InitializeComponent();
            uC_AddorUpdateTestAppointment1.SetData(LocalDrivingLicenseID, TestTypeID, LocalTestAppointmentID, CountTrial);
        }

        private void AddOrUpdateTestVistionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
