using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            this.InitializeComponent();
        }

        private void StudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.educationalDepartmentDataSet.Groups);
            this.studentsTableAdapter.Fill(this.educationalDepartmentDataSet.Students);
        }
    }
}
