namespace iReport.View.WinForms
{
    partial class FormManagerCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerCourse));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxInsertDescription = new System.Windows.Forms.TextBox();
            this.labelInsertDescription = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdateDescription = new System.Windows.Forms.TextBox();
            this.labelUpdateDescription = new System.Windows.Forms.Label();
            this.comboBoxUpdateCourses = new System.Windows.Forms.ComboBox();
            this.labelUpdateCourse = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxDeleteCourses = new System.Windows.Forms.ComboBox();
            this.labelDeleteCourse = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.panelOptions.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.tabControlOptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(381, 107);
            this.panelOptions.TabIndex = 0;
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageInsert);
            this.tabControlOptions.Controls.Add(this.tabPageUpdate);
            this.tabControlOptions.Controls.Add(this.tabPageDelete);
            this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(381, 107);
            this.tabControlOptions.TabIndex = 0;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.buttonInsert);
            this.tabPageInsert.Controls.Add(this.textBoxInsertDescription);
            this.tabPageInsert.Controls.Add(this.labelInsertDescription);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(373, 81);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(290, 45);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxInsertDescription
            // 
            this.textBoxInsertDescription.Location = new System.Drawing.Point(5, 20);
            this.textBoxInsertDescription.MaxLength = 50;
            this.textBoxInsertDescription.Name = "textBoxInsertDescription";
            this.textBoxInsertDescription.Size = new System.Drawing.Size(360, 20);
            this.textBoxInsertDescription.TabIndex = 2;
            // 
            // labelInsertDescription
            // 
            this.labelInsertDescription.AutoSize = true;
            this.labelInsertDescription.Location = new System.Drawing.Point(5, 5);
            this.labelInsertDescription.Name = "labelInsertDescription";
            this.labelInsertDescription.Size = new System.Drawing.Size(60, 13);
            this.labelInsertDescription.TabIndex = 1;
            this.labelInsertDescription.Text = "Description";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateDescription);
            this.tabPageUpdate.Controls.Add(this.labelUpdateDescription);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateCourses);
            this.tabPageUpdate.Controls.Add(this.labelUpdateCourse);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(373, 81);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(290, 45);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdateDescription
            // 
            this.textBoxUpdateDescription.Location = new System.Drawing.Point(190, 20);
            this.textBoxUpdateDescription.MaxLength = 50;
            this.textBoxUpdateDescription.Name = "textBoxUpdateDescription";
            this.textBoxUpdateDescription.Size = new System.Drawing.Size(175, 20);
            this.textBoxUpdateDescription.TabIndex = 3;
            // 
            // labelUpdateDescription
            // 
            this.labelUpdateDescription.AutoSize = true;
            this.labelUpdateDescription.Location = new System.Drawing.Point(190, 5);
            this.labelUpdateDescription.Name = "labelUpdateDescription";
            this.labelUpdateDescription.Size = new System.Drawing.Size(83, 13);
            this.labelUpdateDescription.TabIndex = 2;
            this.labelUpdateDescription.Text = "New description";
            // 
            // comboBoxUpdateCourses
            // 
            this.comboBoxUpdateCourses.FormattingEnabled = true;
            this.comboBoxUpdateCourses.Location = new System.Drawing.Point(5, 20);
            this.comboBoxUpdateCourses.Name = "comboBoxUpdateCourses";
            this.comboBoxUpdateCourses.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateCourses.TabIndex = 1;
            // 
            // labelUpdateCourse
            // 
            this.labelUpdateCourse.AutoSize = true;
            this.labelUpdateCourse.Location = new System.Drawing.Point(5, 5);
            this.labelUpdateCourse.Name = "labelUpdateCourse";
            this.labelUpdateCourse.Size = new System.Drawing.Size(40, 13);
            this.labelUpdateCourse.TabIndex = 0;
            this.labelUpdateCourse.Text = "Course";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Controls.Add(this.comboBoxDeleteCourses);
            this.tabPageDelete.Controls.Add(this.labelDeleteCourse);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(373, 81);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Delete";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(290, 45);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxDeleteCourses
            // 
            this.comboBoxDeleteCourses.FormattingEnabled = true;
            this.comboBoxDeleteCourses.Location = new System.Drawing.Point(5, 20);
            this.comboBoxDeleteCourses.Name = "comboBoxDeleteCourses";
            this.comboBoxDeleteCourses.Size = new System.Drawing.Size(360, 21);
            this.comboBoxDeleteCourses.TabIndex = 1;
            // 
            // labelDeleteCourse
            // 
            this.labelDeleteCourse.AutoSize = true;
            this.labelDeleteCourse.Location = new System.Drawing.Point(5, 5);
            this.labelDeleteCourse.Name = "labelDeleteCourse";
            this.labelDeleteCourse.Size = new System.Drawing.Size(40, 13);
            this.labelDeleteCourse.TabIndex = 0;
            this.labelDeleteCourse.Text = "Course";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCourses.Location = new System.Drawing.Point(0, 107);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.Size = new System.Drawing.Size(381, 367);
            this.dataGridViewCourses.TabIndex = 1;
            // 
            // FormManagerCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 474);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.panelOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(397, 512);
            this.Name = "FormManagerCourse";
            this.Text = "Courses";
            this.Shown += new System.EventHandler(this.FormManagerCourse_Shown);
            this.panelOptions.ResumeLayout(false);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxInsertDescription;
        private System.Windows.Forms.Label labelInsertDescription;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateDescription;
        private System.Windows.Forms.Label labelUpdateDescription;
        private System.Windows.Forms.ComboBox comboBoxUpdateCourses;
        private System.Windows.Forms.Label labelUpdateCourse;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxDeleteCourses;
        private System.Windows.Forms.Label labelDeleteCourse;
    }
}