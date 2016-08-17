namespace iReport.View.WinForms
{
    partial class FormManagerStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerStudent));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.comboBoxInsertCourse = new System.Windows.Forms.ComboBox();
            this.labelInsertCourse = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelInsertBirth = new System.Windows.Forms.Label();
            this.textBoxInsertPhone = new System.Windows.Forms.TextBox();
            this.labelInsertPhone = new System.Windows.Forms.Label();
            this.textBoxInsertEmail = new System.Windows.Forms.TextBox();
            this.labelInsertEmail = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxInsertName = new System.Windows.Forms.TextBox();
            this.labelInsertName = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelUpdateStudent = new System.Windows.Forms.Label();
            this.comboBoxUpdateCourses = new System.Windows.Forms.ComboBox();
            this.labelUpdateCourse = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.comboBoxUpdateStudents = new System.Windows.Forms.ComboBox();
            this.dateTimePickerUpdateBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUpdatePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUpdateEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUpdateCourse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.tabControlOptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(381, 222);
            this.panelOptions.TabIndex = 0;
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageInsert);
            this.tabControlOptions.Controls.Add(this.tabPageUpdate);
            this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(381, 222);
            this.tabControlOptions.TabIndex = 0;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.comboBoxInsertCourse);
            this.tabPageInsert.Controls.Add(this.labelInsertCourse);
            this.tabPageInsert.Controls.Add(this.dateTimePickerBirth);
            this.tabPageInsert.Controls.Add(this.labelInsertBirth);
            this.tabPageInsert.Controls.Add(this.textBoxInsertPhone);
            this.tabPageInsert.Controls.Add(this.labelInsertPhone);
            this.tabPageInsert.Controls.Add(this.textBoxInsertEmail);
            this.tabPageInsert.Controls.Add(this.labelInsertEmail);
            this.tabPageInsert.Controls.Add(this.buttonInsert);
            this.tabPageInsert.Controls.Add(this.textBoxInsertName);
            this.tabPageInsert.Controls.Add(this.labelInsertName);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(373, 196);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // comboBoxInsertCourse
            // 
            this.comboBoxInsertCourse.FormattingEnabled = true;
            this.comboBoxInsertCourse.Location = new System.Drawing.Point(8, 18);
            this.comboBoxInsertCourse.Name = "comboBoxInsertCourse";
            this.comboBoxInsertCourse.Size = new System.Drawing.Size(357, 21);
            this.comboBoxInsertCourse.TabIndex = 11;
            this.comboBoxInsertCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertCourse_SelectedIndexChanged);
            // 
            // labelInsertCourse
            // 
            this.labelInsertCourse.AutoSize = true;
            this.labelInsertCourse.Location = new System.Drawing.Point(8, 3);
            this.labelInsertCourse.Name = "labelInsertCourse";
            this.labelInsertCourse.Size = new System.Drawing.Size(40, 13);
            this.labelInsertCourse.TabIndex = 10;
            this.labelInsertCourse.Text = "Course";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(191, 135);
            this.dateTimePickerBirth.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerBirth.TabIndex = 9;
            // 
            // labelInsertBirth
            // 
            this.labelInsertBirth.AutoSize = true;
            this.labelInsertBirth.Location = new System.Drawing.Point(188, 119);
            this.labelInsertBirth.Name = "labelInsertBirth";
            this.labelInsertBirth.Size = new System.Drawing.Size(28, 13);
            this.labelInsertBirth.TabIndex = 8;
            this.labelInsertBirth.Text = "Birth";
            // 
            // textBoxInsertPhone
            // 
            this.textBoxInsertPhone.Location = new System.Drawing.Point(8, 134);
            this.textBoxInsertPhone.MaxLength = 50;
            this.textBoxInsertPhone.Name = "textBoxInsertPhone";
            this.textBoxInsertPhone.Size = new System.Drawing.Size(175, 20);
            this.textBoxInsertPhone.TabIndex = 7;
            // 
            // labelInsertPhone
            // 
            this.labelInsertPhone.AutoSize = true;
            this.labelInsertPhone.Location = new System.Drawing.Point(8, 119);
            this.labelInsertPhone.Name = "labelInsertPhone";
            this.labelInsertPhone.Size = new System.Drawing.Size(38, 13);
            this.labelInsertPhone.TabIndex = 6;
            this.labelInsertPhone.Text = "Phone";
            // 
            // textBoxInsertEmail
            // 
            this.textBoxInsertEmail.Location = new System.Drawing.Point(6, 96);
            this.textBoxInsertEmail.MaxLength = 50;
            this.textBoxInsertEmail.Name = "textBoxInsertEmail";
            this.textBoxInsertEmail.Size = new System.Drawing.Size(360, 20);
            this.textBoxInsertEmail.TabIndex = 5;
            // 
            // labelInsertEmail
            // 
            this.labelInsertEmail.AutoSize = true;
            this.labelInsertEmail.Location = new System.Drawing.Point(6, 81);
            this.labelInsertEmail.Name = "labelInsertEmail";
            this.labelInsertEmail.Size = new System.Drawing.Size(32, 13);
            this.labelInsertEmail.TabIndex = 4;
            this.labelInsertEmail.Text = "Email";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(292, 161);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxInsertName
            // 
            this.textBoxInsertName.Location = new System.Drawing.Point(6, 57);
            this.textBoxInsertName.MaxLength = 50;
            this.textBoxInsertName.Name = "textBoxInsertName";
            this.textBoxInsertName.Size = new System.Drawing.Size(360, 20);
            this.textBoxInsertName.TabIndex = 2;
            // 
            // labelInsertName
            // 
            this.labelInsertName.AutoSize = true;
            this.labelInsertName.Location = new System.Drawing.Point(6, 42);
            this.labelInsertName.Name = "labelInsertName";
            this.labelInsertName.Size = new System.Drawing.Size(35, 13);
            this.labelInsertName.TabIndex = 1;
            this.labelInsertName.Text = "Name";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.buttonDelete);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateCourse);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.dateTimePickerUpdateBirth);
            this.tabPageUpdate.Controls.Add(this.label1);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdatePhone);
            this.tabPageUpdate.Controls.Add(this.label2);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateEmail);
            this.tabPageUpdate.Controls.Add(this.label3);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateName);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateStudents);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.labelUpdateStudent);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateCourses);
            this.tabPageUpdate.Controls.Add(this.labelUpdateCourse);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(373, 196);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(290, 167);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelUpdateStudent
            // 
            this.labelUpdateStudent.AutoSize = true;
            this.labelUpdateStudent.Location = new System.Drawing.Point(190, 5);
            this.labelUpdateStudent.Name = "labelUpdateStudent";
            this.labelUpdateStudent.Size = new System.Drawing.Size(44, 13);
            this.labelUpdateStudent.TabIndex = 2;
            this.labelUpdateStudent.Text = "Student";
            // 
            // comboBoxUpdateCourses
            // 
            this.comboBoxUpdateCourses.FormattingEnabled = true;
            this.comboBoxUpdateCourses.Location = new System.Drawing.Point(5, 20);
            this.comboBoxUpdateCourses.Name = "comboBoxUpdateCourses";
            this.comboBoxUpdateCourses.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateCourses.TabIndex = 1;
            this.comboBoxUpdateCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateCourses_SelectedIndexChanged);
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
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(0, 222);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(381, 252);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // comboBoxUpdateStudents
            // 
            this.comboBoxUpdateStudents.FormattingEnabled = true;
            this.comboBoxUpdateStudents.Location = new System.Drawing.Point(190, 20);
            this.comboBoxUpdateStudents.Name = "comboBoxUpdateStudents";
            this.comboBoxUpdateStudents.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateStudents.TabIndex = 5;
            this.comboBoxUpdateStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateStudents_SelectedIndexChanged);
            // 
            // dateTimePickerUpdateBirth
            // 
            this.dateTimePickerUpdateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUpdateBirth.Location = new System.Drawing.Point(191, 135);
            this.dateTimePickerUpdateBirth.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePickerUpdateBirth.Name = "dateTimePickerUpdateBirth";
            this.dateTimePickerUpdateBirth.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerUpdateBirth.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "New birth";
            // 
            // textBoxUpdatePhone
            // 
            this.textBoxUpdatePhone.Location = new System.Drawing.Point(8, 134);
            this.textBoxUpdatePhone.MaxLength = 50;
            this.textBoxUpdatePhone.Name = "textBoxUpdatePhone";
            this.textBoxUpdatePhone.Size = new System.Drawing.Size(175, 20);
            this.textBoxUpdatePhone.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "New phone";
            // 
            // textBoxUpdateEmail
            // 
            this.textBoxUpdateEmail.Location = new System.Drawing.Point(6, 96);
            this.textBoxUpdateEmail.MaxLength = 50;
            this.textBoxUpdateEmail.Name = "textBoxUpdateEmail";
            this.textBoxUpdateEmail.Size = new System.Drawing.Size(360, 20);
            this.textBoxUpdateEmail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "New email";
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(190, 59);
            this.textBoxUpdateName.MaxLength = 50;
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(174, 20);
            this.textBoxUpdateName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "New name";
            // 
            // comboBoxUpdateCourse
            // 
            this.comboBoxUpdateCourse.FormattingEnabled = true;
            this.comboBoxUpdateCourse.Location = new System.Drawing.Point(6, 59);
            this.comboBoxUpdateCourse.Name = "comboBoxUpdateCourse";
            this.comboBoxUpdateCourse.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateCourse.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "New course";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(209, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormManagerStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 474);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.panelOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(397, 512);
            this.Name = "FormManagerStudent";
            this.Text = "Students";
            this.Shown += new System.EventHandler(this.FormManagerStudent_Shown);
            this.panelOptions.ResumeLayout(false);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxInsertName;
        private System.Windows.Forms.Label labelInsertName;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelUpdateStudent;
        private System.Windows.Forms.ComboBox comboBoxUpdateCourses;
        private System.Windows.Forms.Label labelUpdateCourse;
        private System.Windows.Forms.ComboBox comboBoxInsertCourse;
        private System.Windows.Forms.Label labelInsertCourse;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelInsertBirth;
        private System.Windows.Forms.TextBox textBoxInsertPhone;
        private System.Windows.Forms.Label labelInsertPhone;
        private System.Windows.Forms.TextBox textBoxInsertEmail;
        private System.Windows.Forms.Label labelInsertEmail;
        private System.Windows.Forms.ComboBox comboBoxUpdateStudents;
        private System.Windows.Forms.ComboBox comboBoxUpdateCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdateBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUpdatePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUpdateEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
    }
}