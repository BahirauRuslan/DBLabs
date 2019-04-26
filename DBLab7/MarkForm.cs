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
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.educationalDepartmentDataSet.Students);
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.educationalDepartmentDataSet.Groups);
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Plans' table. You can move, or remove it, as needed.
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
            this.markRecordsTableAdapter.Fill(this.educationalDepartmentDataSet.MarkRecords);
        }
    }
}
