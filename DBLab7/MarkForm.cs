using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            this.InitializeComponent();
        }

        private void MarkRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.markRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            this.markRecordsTableAdapter.Fill(this.educationalDepartmentDataSet.MarkRecords);
        }
    }
}
