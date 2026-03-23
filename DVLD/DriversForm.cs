using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer;

namespace DVLD_Persntation
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
            dataGridViewTestTypes.DataSource = DriverService.GetAllDrivers();
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
