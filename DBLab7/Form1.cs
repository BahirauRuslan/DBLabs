using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class MainForm : Form
    {
        private SubjectsForm subjectsForm;
        private PlansForm plansForm;
        private PlanContentForm planContentForm;
        private GroupForm groupForm;
        private StudentsForm studentsForm;
        private MarkForm markForm;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void ShowForm<T>(ref T form) where T : Form, new()
        {
            if (form == null || form.IsDisposed)
            {
                form = new T();
            }

            form.Show();
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(ref this.subjectsForm);
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(ref this.plansForm);
        }

        private void PlanContentButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(ref this.planContentForm);
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(ref this.groupForm);
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(ref this.studentsForm);
        }

        private void MarkButton_Click(object sender, EventArgs e)
        {
            this.ShowForm(ref this.markForm);
        }
    }
}
