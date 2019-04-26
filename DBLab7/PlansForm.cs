using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class PlansForm : Form
    {
        public PlansForm()
        {
            this.InitializeComponent();
        }

        private void PlansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void PlansForm_Load(object sender, EventArgs e)
        {
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
        }
    }
}
