using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iReport.View.WinForms
{
    public partial class FormMain : Form
    {
        private FormManagerCourse formManagerCourse;
        private FormManagerSubject formManagerSubject;
        private FormManagerStudent formManagerStudent;
        private FormManagerReportCard formManagerReportCard;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            if (formManagerCourse == null)
            {                
                formManagerCourse = new FormManagerCourse();
            }
            try
            {
                formManagerCourse.Show();
            }
            catch (Exception)
            {
                formManagerCourse = new FormManagerCourse();
                formManagerCourse.Show();
            }
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (formManagerSubject == null)
            {
                formManagerSubject = new FormManagerSubject();
            }
            try
            {        
                formManagerSubject.Show();
            }
            catch (Exception)
            {
                formManagerSubject = new FormManagerSubject();
                formManagerSubject.Show();
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (formManagerStudent == null)
            {
                formManagerStudent = new FormManagerStudent();
            }
            try
            {
                formManagerStudent.Show();
            }
            catch (Exception)
            {
                formManagerStudent = new FormManagerStudent();
                formManagerStudent.Show();
            }
        }

        private void btnReportCard_Click(object sender, EventArgs e)
        {
            if (formManagerReportCard == null)
            {
                formManagerReportCard = new FormManagerReportCard();
            }
            try
            {
                formManagerReportCard.Show();
            }
            catch (Exception)
            {
                formManagerReportCard = new FormManagerReportCard();
                formManagerReportCard.Show();
            }
        }
    }
}
