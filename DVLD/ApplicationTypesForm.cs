using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class ApplicationTypesForm : Form
    {
        private DataTable appTable;
        public ApplicationTypesForm()
        {
            InitializeComponent();
            LoadApplicationTypes();
        }

        private void LoadApplicationTypes()
        {
            //dataGridViewUsers. =  DVLD_BusinessLogicLayer.ApplicationTypesService.GetApplicationTypes();
            dataGridViewApplicationTypes.DataSource = DVLD_BusinessLogicLayer.ApplicationTypesService.GetApplicationTypes();
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewApplicationTypes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (appTable == null || e.ColumnIndex < 0)
                return;

            string columnName = dataGridViewApplicationTypes.Columns[e.ColumnIndex].DataPropertyName;

            appTable.DefaultView.Sort = $"{columnName} {"ASC"}";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateApplicationTypeForm updateForm = new UpdateApplicationTypeForm(Convert.ToInt32(dataGridViewApplicationTypes.CurrentRow.Cells["ID"].Value));
            updateForm.ShowDialog();
        }

        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewApplicationTypes.DataSource = DVLD_BusinessLogicLayer.ApplicationTypesService.GetApplicationTypes();
        }
    }
}
