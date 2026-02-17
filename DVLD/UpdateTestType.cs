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
    public partial class UpdateTestType : Form
    {
        private int _testTypeId;
        private TestTypesService _testTypesService;
        public UpdateTestType(int id)
        {
            InitializeComponent();
            _testTypeId = id;
            LoadTestTypeData();
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTestTypeData()
        {
            _testTypesService = TestTypesService.FindTestTypeById(_testTypeId);
            if (_testTypeId != -1)
            {
                lblTestTypeID.Text = _testTypesService.Id.ToString();
                tbTestTypeName.Text = _testTypesService.Name;
                tbTestTypeDescreption.Text = _testTypesService.Description;
                tbTestTypeFees.Text = _testTypesService.Fees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _testTypesService.Name = tbTestTypeName.Text;
            _testTypesService.Description = tbTestTypeDescreption.Text;
            _testTypesService.Fees = decimal.Parse(tbTestTypeFees.Text);
            if (_testTypesService.UpdateTestType())
            {
                MessageBox.Show("Test type updated successfully.");
                this.Close();
            }
                
        }

        private void tbTestTypeFees_TextChanged(object sender, EventArgs e)
        {
            if(!decimal.TryParse(tbTestTypeFees.Text, out decimal fees))
            {
                tbTestTypeFees.Text = tbTestTypeFees.Text.Remove(tbTestTypeFees.Text.Length - 1);
                errorProvider1.SetError(tbTestTypeFees, "Please enter a valid number for fees.");
            }
            else
            {
                errorProvider1.SetError(tbTestTypeFees, string.Empty);
            }

        }
    }
}
