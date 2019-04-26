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
            this.planContentTableAdapter.Fill(this.educationalDepartmentDataSet.PlanContent);
        }
    }
}
