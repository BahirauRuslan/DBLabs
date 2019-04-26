namespace DBLab7
{
    public partial class MarkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private EducationalDepartmentDataSet educationalDepartmentDataSet;
        private System.Windows.Forms.BindingSource markRecordsBindingSource;
        private EducationalDepartmentDataSetTableAdapters.MarkRecordsTableAdapter markRecordsTableAdapter;
        private EducationalDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator markRecordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton markRecordsBindingNavigatorSaveItem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkForm));
            this.educationalDepartmentDataSet = new DBLab7.EducationalDepartmentDataSet();
            this.markRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markRecordsTableAdapter = new DBLab7.EducationalDepartmentDataSetTableAdapters.MarkRecordsTableAdapter();
            this.tableAdapterManager = new DBLab7.EducationalDepartmentDataSetTableAdapters.TableAdapterManager();
            this.markRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.markRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.plansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plansTableAdapter = new DBLab7.EducationalDepartmentDataSetTableAdapters.PlansTableAdapter();
            this.plansComboBox = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new DBLab7.EducationalDepartmentDataSetTableAdapters.GroupsTableAdapter();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new DBLab7.EducationalDepartmentDataSetTableAdapters.StudentsTableAdapter();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.markRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.markRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.educationalDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingNavigator)).BeginInit();
            this.markRecordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // educationalDepartmentDataSet
            // 
            this.educationalDepartmentDataSet.DataSetName = "EducationalDepartmentDataSet";
            this.educationalDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markRecordsBindingSource
            // 
            this.markRecordsBindingSource.DataMember = "MarkRecords";
            this.markRecordsBindingSource.DataSource = this.educationalDepartmentDataSet;
            // 
            // markRecordsTableAdapter
            // 
            this.markRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.MarkRecordsTableAdapter = this.markRecordsTableAdapter;
            this.tableAdapterManager.PlanContentTableAdapter = null;
            this.tableAdapterManager.PlansTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBLab7.EducationalDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // markRecordsBindingNavigator
            // 
            this.markRecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.markRecordsBindingNavigator.BindingSource = this.markRecordsBindingSource;
            this.markRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.markRecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.markRecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.markRecordsBindingNavigatorSaveItem});
            this.markRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.markRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.markRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.markRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.markRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.markRecordsBindingNavigator.Name = "markRecordsBindingNavigator";
            this.markRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.markRecordsBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.markRecordsBindingNavigator.TabIndex = 0;
            this.markRecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // markRecordsBindingNavigatorSaveItem
            // 
            this.markRecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.markRecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("markRecordsBindingNavigatorSaveItem.Image")));
            this.markRecordsBindingNavigatorSaveItem.Name = "markRecordsBindingNavigatorSaveItem";
            this.markRecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.markRecordsBindingNavigatorSaveItem.Text = "Save Data";
            this.markRecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.MarkRecordsBindingNavigatorSaveItem_Click);
            // 
            // plansBindingSource
            // 
            this.plansBindingSource.DataMember = "Plans";
            this.plansBindingSource.DataSource = this.educationalDepartmentDataSet;
            // 
            // plansTableAdapter
            // 
            this.plansTableAdapter.ClearBeforeFill = true;
            // 
            // plansComboBox
            // 
            this.plansComboBox.DataSource = this.plansBindingSource;
            this.plansComboBox.DisplayMember = "Speciality";
            this.plansComboBox.FormattingEnabled = true;
            this.plansComboBox.Location = new System.Drawing.Point(462, 47);
            this.plansComboBox.Name = "plansComboBox";
            this.plansComboBox.Size = new System.Drawing.Size(300, 21);
            this.plansComboBox.TabIndex = 1;
            this.plansComboBox.ValueMember = "Id";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "FK_Groups_Plans";
            this.groupsBindingSource.DataSource = this.plansBindingSource;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DataSource = this.groupsBindingSource;
            this.groupsComboBox.DisplayMember = "Number";
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(462, 97);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(300, 21);
            this.groupsComboBox.TabIndex = 2;
            this.groupsComboBox.ValueMember = "Id";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "FK_Students_Groups";
            this.studentsBindingSource.DataSource = this.groupsBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.DataSource = this.studentsBindingSource;
            this.studentsComboBox.DisplayMember = "FullName";
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(462, 149);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(300, 21);
            this.studentsComboBox.TabIndex = 3;
            this.studentsComboBox.ValueMember = "Id";
            // 
            // markRecordsBindingSource1
            // 
            this.markRecordsBindingSource1.DataMember = "FK_MarkRecords_Students";
            this.markRecordsBindingSource1.DataSource = this.studentsBindingSource;
            // 
            // markRecordsDataGridView
            // 
            this.markRecordsDataGridView.AutoGenerateColumns = false;
            this.markRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markRecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.markRecordsDataGridView.DataSource = this.markRecordsBindingSource1;
            this.markRecordsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.markRecordsDataGridView.Name = "markRecordsDataGridView";
            this.markRecordsDataGridView.Size = new System.Drawing.Size(444, 293);
            this.markRecordsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlanContentId";
            this.dataGridViewTextBoxColumn3.HeaderText = "PlanContentId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mark";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mark";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 333);
            this.Controls.Add(this.markRecordsDataGridView);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.groupsComboBox);
            this.Controls.Add(this.plansComboBox);
            this.Controls.Add(this.markRecordsBindingNavigator);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationalDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingNavigator)).EndInit();
            this.markRecordsBindingNavigator.ResumeLayout(false);
            this.markRecordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource plansBindingSource;
        private EducationalDepartmentDataSetTableAdapters.PlansTableAdapter plansTableAdapter;
        private System.Windows.Forms.ComboBox plansComboBox;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private EducationalDepartmentDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.ComboBox groupsComboBox;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EducationalDepartmentDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.BindingSource markRecordsBindingSource1;
        private System.Windows.Forms.DataGridView markRecordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}