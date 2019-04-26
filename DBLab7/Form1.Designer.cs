namespace DBLab7
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Button planContentButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button markButton;

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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectButton = new System.Windows.Forms.Button();
            this.planButton = new System.Windows.Forms.Button();
            this.planContentButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.markButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(71, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных - Кафедра";
            // 
            // subjectButton
            // 
            this.subjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectButton.Location = new System.Drawing.Point(67, 58);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(308, 41);
            this.subjectButton.TabIndex = 1;
            this.subjectButton.Text = "Дисциплины";
            this.subjectButton.UseVisualStyleBackColor = true;
            this.subjectButton.Click += new System.EventHandler(this.SubjectButton_Click);
            // 
            // planButton
            // 
            this.planButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planButton.Location = new System.Drawing.Point(67, 105);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(308, 41);
            this.planButton.TabIndex = 2;
            this.planButton.Text = "Планы";
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.PlanButton_Click);
            // 
            // planContentButton
            // 
            this.planContentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planContentButton.Location = new System.Drawing.Point(67, 152);
            this.planContentButton.Name = "planContentButton";
            this.planContentButton.Size = new System.Drawing.Size(308, 41);
            this.planContentButton.TabIndex = 3;
            this.planContentButton.Text = "Содержимое планов";
            this.planContentButton.UseVisualStyleBackColor = true;
            this.planContentButton.Click += new System.EventHandler(this.PlanContentButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupButton.Location = new System.Drawing.Point(67, 199);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(308, 41);
            this.groupButton.TabIndex = 4;
            this.groupButton.Text = "Группы";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentButton.Location = new System.Drawing.Point(67, 246);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(308, 41);
            this.studentButton.TabIndex = 5;
            this.studentButton.Text = "Студенты";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // markButton
            // 
            this.markButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markButton.Location = new System.Drawing.Point(67, 293);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(308, 41);
            this.markButton.TabIndex = 6;
            this.markButton.Text = "Оценки";
            this.markButton.UseVisualStyleBackColor = true;
            this.markButton.Click += new System.EventHandler(this.MarkButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 345);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.planContentButton);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.subjectButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Лаб. №7, Руслан, гр. 10701116";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}