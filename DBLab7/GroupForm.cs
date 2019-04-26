﻿using System;
using System.Windows.Forms;

namespace DBLab7
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            this.InitializeComponent();
        }

        private void GroupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationalDepartmentDataSet.Plans' table. You can move, or remove it, as needed.
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
            this.groupsTableAdapter.Fill(this.educationalDepartmentDataSet.Groups);
        }
    }
}
