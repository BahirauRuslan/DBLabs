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
            this.studentsTableAdapter.Fill(this.educationalDepartmentDataSet.Students);
        }
    }
}
