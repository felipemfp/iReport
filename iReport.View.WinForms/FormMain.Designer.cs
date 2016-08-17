namespace iReport.View.WinForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnReportCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCourse
            // 
            this.btnCourse.BackgroundImage = global::iReport.View.WinForms.Properties.Resources.course_icon;
            this.btnCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Location = new System.Drawing.Point(12, 12);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(256, 256);
            this.btnCourse.TabIndex = 0;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackgroundImage = global::iReport.View.WinForms.Properties.Resources.student_icon;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Location = new System.Drawing.Point(274, 12);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(256, 256);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackgroundImage = global::iReport.View.WinForms.Properties.Resources.subject_icon;
            this.btnSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Location = new System.Drawing.Point(12, 274);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(256, 256);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnReportCard
            // 
            this.btnReportCard.BackgroundImage = global::iReport.View.WinForms.Properties.Resources.report_card_icon;
            this.btnReportCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportCard.FlatAppearance.BorderSize = 0;
            this.btnReportCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportCard.Location = new System.Drawing.Point(273, 274);
            this.btnReportCard.Name = "btnReportCard";
            this.btnReportCard.Size = new System.Drawing.Size(256, 256);
            this.btnReportCard.TabIndex = 3;
            this.btnReportCard.UseVisualStyleBackColor = true;
            this.btnReportCard.Click += new System.EventHandler(this.btnReportCard_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 542);
            this.Controls.Add(this.btnReportCard);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnReportCard;

    }
}