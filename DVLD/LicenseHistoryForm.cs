using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class LicenseHistoryForm : Form
    {
        public  LicenseHistoryForm(string SSN, int page)
        {
            InitializeComponent();
            var userService = DVLD_BusinessLogicLayer.UserService.GetUserBySSN(SSN);
            uC_PersonInfomation1.loadData(userService);
            tabControl1.SelectedIndex = page - 1;

            int driverID = DVLD_BusinessLogicLayer.DriverService.GetDriverIDByUserID(userService.User_ID);
            if (driverID != -1)
            {
                dataGridViewLocalLicense.DataSource = DVLD_BusinessLogicLayer.LicenseService.GetLocalDriverLicenseHistoryBy(driverID);
                dataGridViewInternationlLicense.DataSource = DVLD_BusinessLogicLayer.LicenseService.GetInerntionalDriverLicenseHistoryBy(driverID);

            }

        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
