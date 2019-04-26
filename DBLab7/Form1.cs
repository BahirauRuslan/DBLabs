using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(new SubjectsForm());
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(new PlansForm());
        }

        private void PlanContentButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(new PlanContentForm());
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(new GroupForm());
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(new StudentsForm());
        }

        private void MarkButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(new MarkForm());
        }
    }
}
