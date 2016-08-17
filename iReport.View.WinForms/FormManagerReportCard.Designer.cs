namespace iReport.View.WinForms
{
    partial class FormManagerReportCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerReportCard));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.comboBoxInsertSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxInsertStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxInsertCourse = new System.Windows.Forms.ComboBox();
            this.textBoxInsertYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInsertDescription = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.comboBoxUpdateQuarter = new System.Windows.Forms.ComboBox();
            this.comboBoxUpdateSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxUpdateStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxUpdateCourse = new System.Windows.Forms.ComboBox();
            this.textBoxUpdateValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.comboBoxDeleteSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDeleteYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewReportCards = new System.Windows.Forms.DataGridView();
            this.textBoxUpdateYear = new System.Windows.Forms.TextBox();
            this.panelOptions.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportCards)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.tabControlOptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(381, 144);
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
            this.tabControlOptions.Size = new System.Drawing.Size(381, 144);
            this.tabControlOptions.TabIndex = 0;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.comboBoxInsertSubject);
            this.tabPageInsert.Controls.Add(this.comboBoxInsertStudent);
            this.tabPageInsert.Controls.Add(this.comboBoxInsertCourse);
            this.tabPageInsert.Controls.Add(this.textBoxInsertYear);
            this.tabPageInsert.Controls.Add(this.label3);
            this.tabPageInsert.Controls.Add(this.label2);
            this.tabPageInsert.Controls.Add(this.label1);
            this.tabPageInsert.Controls.Add(this.labelInsertDescription);
            this.tabPageInsert.Controls.Add(this.buttonInsert);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(373, 118);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // comboBoxInsertSubject
            // 
            this.comboBoxInsertSubject.FormattingEnabled = true;
            this.comboBoxInsertSubject.Location = new System.Drawing.Point(8, 60);
            this.comboBoxInsertSubject.Name = "comboBoxInsertSubject";
            this.comboBoxInsertSubject.Size = new System.Drawing.Size(175, 21);
            this.comboBoxInsertSubject.TabIndex = 29;
            this.comboBoxInsertSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertSubject_SelectedIndexChanged);
            // 
            // comboBoxInsertStudent
            // 
            this.comboBoxInsertStudent.FormattingEnabled = true;
            this.comboBoxInsertStudent.Location = new System.Drawing.Point(189, 22);
            this.comboBoxInsertStudent.Name = "comboBoxInsertStudent";
            this.comboBoxInsertStudent.Size = new System.Drawing.Size(175, 21);
            this.comboBoxInsertStudent.TabIndex = 28;
            this.comboBoxInsertStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertStudent_SelectedIndexChanged);
            // 
            // comboBoxInsertCourse
            // 
            this.comboBoxInsertCourse.FormattingEnabled = true;
            this.comboBoxInsertCourse.Location = new System.Drawing.Point(8, 24);
            this.comboBoxInsertCourse.Name = "comboBoxInsertCourse";
            this.comboBoxInsertCourse.Size = new System.Drawing.Size(175, 21);
            this.comboBoxInsertCourse.TabIndex = 27;
            this.comboBoxInsertCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertCourse_SelectedIndexChanged);
            // 
            // textBoxInsertYear
            // 
            this.textBoxInsertYear.Location = new System.Drawing.Point(189, 61);
            this.textBoxInsertYear.MaxLength = 50;
            this.textBoxInsertYear.Name = "textBoxInsertYear";
            this.textBoxInsertYear.Size = new System.Drawing.Size(175, 20);
            this.textBoxInsertYear.TabIndex = 26;
            this.textBoxInsertYear.TextChanged += new System.EventHandler(this.textBoxInsertYear_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student";
            // 
            // labelInsertDescription
            // 
            this.labelInsertDescription.AutoSize = true;
            this.labelInsertDescription.Location = new System.Drawing.Point(8, 8);
            this.labelInsertDescription.Name = "labelInsertDescription";
            this.labelInsertDescription.Size = new System.Drawing.Size(40, 13);
            this.labelInsertDescription.TabIndex = 19;
            this.labelInsertDescription.Text = "Course";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(289, 87);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 18;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateYear);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateQuarter);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateSubject);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateStudent);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdateCourse);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateValue);
            this.tabPageUpdate.Controls.Add(this.label13);
            this.tabPageUpdate.Controls.Add(this.label12);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(373, 118);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxUpdateQuarter
            // 
            this.comboBoxUpdateQuarter.FormattingEnabled = true;
            this.comboBoxUpdateQuarter.Location = new System.Drawing.Point(279, 60);
            this.comboBoxUpdateQuarter.Name = "comboBoxUpdateQuarter";
            this.comboBoxUpdateQuarter.Size = new System.Drawing.Size(85, 21);
            this.comboBoxUpdateQuarter.TabIndex = 36;
            this.comboBoxUpdateQuarter.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateQuarter_SelectedIndexChanged);
            // 
            // comboBoxUpdateSubject
            // 
            this.comboBoxUpdateSubject.FormattingEnabled = true;
            this.comboBoxUpdateSubject.Location = new System.Drawing.Point(8, 60);
            this.comboBoxUpdateSubject.Name = "comboBoxUpdateSubject";
            this.comboBoxUpdateSubject.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateSubject.TabIndex = 34;
            this.comboBoxUpdateSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateSubject_SelectedIndexChanged);
            // 
            // comboBoxUpdateStudent
            // 
            this.comboBoxUpdateStudent.FormattingEnabled = true;
            this.comboBoxUpdateStudent.Location = new System.Drawing.Point(189, 22);
            this.comboBoxUpdateStudent.Name = "comboBoxUpdateStudent";
            this.comboBoxUpdateStudent.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateStudent.TabIndex = 33;
            this.comboBoxUpdateStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateStudent_SelectedIndexChanged);
            // 
            // comboBoxUpdateCourse
            // 
            this.comboBoxUpdateCourse.FormattingEnabled = true;
            this.comboBoxUpdateCourse.Location = new System.Drawing.Point(8, 24);
            this.comboBoxUpdateCourse.Name = "comboBoxUpdateCourse";
            this.comboBoxUpdateCourse.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUpdateCourse.TabIndex = 32;
            this.comboBoxUpdateCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateCourse_SelectedIndexChanged);
            // 
            // textBoxUpdateValue
            // 
            this.textBoxUpdateValue.Location = new System.Drawing.Point(48, 89);
            this.textBoxUpdateValue.MaxLength = 50;
            this.textBoxUpdateValue.Name = "textBoxUpdateValue";
            this.textBoxUpdateValue.Size = new System.Drawing.Size(226, 20);
            this.textBoxUpdateValue.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Quarter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Course";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(280, 87);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.comboBoxDeleteSubject);
            this.tabPageDelete.Controls.Add(this.comboBoxDeleteStudent);
            this.tabPageDelete.Controls.Add(this.comboBoxDeleteCourse);
            this.tabPageDelete.Controls.Add(this.textBoxDeleteYear);
            this.tabPageDelete.Controls.Add(this.label8);
            this.tabPageDelete.Controls.Add(this.label9);
            this.tabPageDelete.Controls.Add(this.label10);
            this.tabPageDelete.Controls.Add(this.label11);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(373, 118);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Delete";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxDeleteSubject
            // 
            this.comboBoxDeleteSubject.FormattingEnabled = true;
            this.comboBoxDeleteSubject.Location = new System.Drawing.Point(8, 60);
            this.comboBoxDeleteSubject.Name = "comboBoxDeleteSubject";
            this.comboBoxDeleteSubject.Size = new System.Drawing.Size(175, 21);
            this.comboBoxDeleteSubject.TabIndex = 33;
            this.comboBoxDeleteSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteSubject_SelectedIndexChanged);
            // 
            // comboBoxDeleteStudent
            // 
            this.comboBoxDeleteStudent.FormattingEnabled = true;
            this.comboBoxDeleteStudent.Location = new System.Drawing.Point(189, 22);
            this.comboBoxDeleteStudent.Name = "comboBoxDeleteStudent";
            this.comboBoxDeleteStudent.Size = new System.Drawing.Size(175, 21);
            this.comboBoxDeleteStudent.TabIndex = 32;
            this.comboBoxDeleteStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteStudent_SelectedIndexChanged);
            // 
            // comboBoxDeleteCourse
            // 
            this.comboBoxDeleteCourse.FormattingEnabled = true;
            this.comboBoxDeleteCourse.Location = new System.Drawing.Point(8, 24);
            this.comboBoxDeleteCourse.Name = "comboBoxDeleteCourse";
            this.comboBoxDeleteCourse.Size = new System.Drawing.Size(175, 21);
            this.comboBoxDeleteCourse.TabIndex = 31;
            this.comboBoxDeleteCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteCourse_SelectedIndexChanged);
            // 
            // textBoxDeleteYear
            // 
            this.textBoxDeleteYear.Location = new System.Drawing.Point(189, 61);
            this.textBoxDeleteYear.MaxLength = 50;
            this.textBoxDeleteYear.Name = "textBoxDeleteYear";
            this.textBoxDeleteYear.Size = new System.Drawing.Size(175, 20);
            this.textBoxDeleteYear.TabIndex = 30;
            this.textBoxDeleteYear.TextChanged += new System.EventHandler(this.textBoxDeleteYear_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Subject";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Student";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Course";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(289, 87);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewReportCards
            // 
            this.dataGridViewReportCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReportCards.Location = new System.Drawing.Point(0, 144);
            this.dataGridViewReportCards.Name = "dataGridViewReportCards";
            this.dataGridViewReportCards.ReadOnly = true;
            this.dataGridViewReportCards.Size = new System.Drawing.Size(381, 330);
            this.dataGridViewReportCards.TabIndex = 1;
            // 
            // textBoxUpdateYear
            // 
            this.textBoxUpdateYear.Location = new System.Drawing.Point(189, 60);
            this.textBoxUpdateYear.MaxLength = 50;
            this.textBoxUpdateYear.Name = "textBoxUpdateYear";
            this.textBoxUpdateYear.Size = new System.Drawing.Size(85, 20);
            this.textBoxUpdateYear.TabIndex = 37;
            this.textBoxUpdateYear.TextChanged += new System.EventHandler(this.textBoxUpdateYear_TextChanged);
            // 
            // FormManagerReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 474);
            this.Controls.Add(this.dataGridViewReportCards);
            this.Controls.Add(this.panelOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(397, 512);
            this.Name = "FormManagerReportCard";
            this.Text = "Report Cards";
            this.Shown += new System.EventHandler(this.FormManagerCourse_Shown);
            this.panelOptions.ResumeLayout(false);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.DataGridView dataGridViewReportCards;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.ComboBox comboBoxInsertSubject;
        private System.Windows.Forms.ComboBox comboBoxInsertStudent;
        private System.Windows.Forms.ComboBox comboBoxInsertCourse;
        private System.Windows.Forms.TextBox textBoxInsertYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInsertDescription;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxUpdateQuarter;
        private System.Windows.Forms.ComboBox comboBoxUpdateSubject;
        private System.Windows.Forms.ComboBox comboBoxUpdateStudent;
        private System.Windows.Forms.ComboBox comboBoxUpdateCourse;
        private System.Windows.Forms.TextBox textBoxUpdateValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.ComboBox comboBoxDeleteSubject;
        private System.Windows.Forms.ComboBox comboBoxDeleteStudent;
        private System.Windows.Forms.ComboBox comboBoxDeleteCourse;
        private System.Windows.Forms.TextBox textBoxDeleteYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxUpdateYear;
    }
}