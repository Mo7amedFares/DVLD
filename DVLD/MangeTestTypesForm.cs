using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class MangeTestTypesForm : Form
    {
        private DataTable appTable;
        public MangeTestTypesForm()
        {
            InitializeComponent();
            LoadTestTypes();
        }

        private void LoadTestTypes()
        {
            dataGridViewTestTypes.DataSource = DVLD_BusinessLogicLayer.TestTypesService.GetTestTypes();
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTestType updateForm = new UpdateTestType(Convert.ToInt32(dataGridViewTestTypes.CurrentRow.Cells["ID"].Value));
            updateForm.ShowDialog();
        }

        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewTestTypes.DataSource = DVLD_BusinessLogicLayer.TestTypesService.GetTestTypes();
        }

        private void dataGridViewTestTypes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (appTable == null || e.ColumnIndex < 0)
                return;

            string columnName = dataGridViewTestTypes.Columns[e.ColumnIndex].DataPropertyName;

            appTable.DefaultView.Sort = $"{columnName} {"ASC"}";
        }
    }
}
