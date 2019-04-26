using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class PlanContentForm : Form
    {
        public PlanContentForm()
        {
            this.InitializeComponent();
        }

        private void PlanContentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planContentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void PlanContentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Plans' table. You can move, or remove it, as needed.
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Plans' table. You can move, or remove it, as needed.
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
            this.planContentTableAdapter.Fill(this.educationalDepartmentDataSet.PlanContent);
        }
    }
}
