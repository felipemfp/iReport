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
    public partial class FormManagerReportCard : Form
    {
        private Business.ReportCard BReportCard;

        public FormManagerReportCard()
        {
            InitializeComponent();
            BReportCard = new Business.ReportCard();
            dataGridViewReportCards.DataSource = null;
            dataGridViewReportCards.DataSource = BReportCard.GetList();
        }

        private void FormManagerCourse_Shown(object sender, EventArgs e)
        {
            // TAB INSERT
            comboBoxInsertCourse.DataSource = new Business.Course().GetList();
            comboBoxInsertCourse.ValueMember = "Id";
            comboBoxInsertCourse.DisplayMember = "Description";

            comboBoxInsertSubject.DataSource = new Business.Subject().GetList();
            comboBoxInsertSubject.ValueMember = "Id";
            comboBoxInsertSubject.DisplayMember = "Description";

            // TAB UPDATE
            comboBoxUpdateCourse.DataSource = new Business.Course().GetList();
            comboBoxUpdateCourse.ValueMember = "Id";
            comboBoxUpdateCourse.DisplayMember = "Description";

            comboBoxUpdateSubject.DataSource = new Business.Subject().GetList();
            comboBoxUpdateSubject.ValueMember = "Id";
            comboBoxUpdateSubject.DisplayMember = "Description";

            List<Quarter> quarters = new List<Quarter> 
            { 
                new Quarter { Id = 1, Description = "Quarter 1" },
                new Quarter { Id = 2, Description = "Quarter 2" },
                new Quarter { Id = 3, Description = "Quarter 3" },
                new Quarter { Id = 4, Description = "Quarter 4" },
                new Quarter { Id = 5, Description = "Final" }
            };
            comboBoxUpdateQuarter.DataSource = quarters;
            comboBoxUpdateQuarter.ValueMember = "Id";
            comboBoxUpdateQuarter.DisplayMember = "Description";

            // TAB DELETE
            comboBoxDeleteCourse.DataSource = new Business.Course().GetList();
            comboBoxDeleteCourse.ValueMember = "Id";
            comboBoxDeleteCourse.DisplayMember = "Description";

            comboBoxDeleteSubject.DataSource = new Business.Subject().GetList();
            comboBoxDeleteSubject.ValueMember = "Id";
            comboBoxDeleteSubject.DisplayMember = "Description";
        }

        private void DataReload(string tab)
        {
            int idStudent = 0;
            int idSubject = 0;
            int year = 0;

            if (tab == "insert")
            {
                idStudent = comboBoxInsertStudent.SelectedItem != null ? ((Model.Student)comboBoxInsertStudent.SelectedItem).Id : 0;
                idSubject = comboBoxInsertSubject.SelectedItem != null ? ((Model.Subject)comboBoxInsertSubject.SelectedItem).Id : 0;
                year = !String.IsNullOrWhiteSpace(textBoxInsertYear.Text) ? int.Parse(textBoxInsertYear.Text) : 0;
            }
            else if (tab == "update")
            {
                idStudent = comboBoxUpdateStudent.SelectedItem != null ? ((Model.Student)comboBoxUpdateStudent.SelectedItem).Id : 0;
                idSubject = comboBoxUpdateSubject.SelectedItem != null ? ((Model.Subject)comboBoxUpdateSubject.SelectedItem).Id : 0;
                year = !String.IsNullOrWhiteSpace(textBoxUpdateYear.Text) ? int.Parse(textBoxUpdateYear.Text) : 0;
            }
            else if (tab == "delete")
            {
                idStudent = comboBoxDeleteStudent.SelectedItem != null ? ((Model.Student)comboBoxDeleteStudent.SelectedItem).Id : 0;
                idSubject = comboBoxDeleteSubject.SelectedItem != null ? ((Model.Subject)comboBoxDeleteSubject.SelectedItem).Id : 0;
                year = !String.IsNullOrWhiteSpace(textBoxDeleteYear.Text) ? int.Parse(textBoxDeleteYear.Text) : 0;
            }

            dataGridViewReportCards.DataSource = null;
            dataGridViewReportCards.DataSource = BReportCard.GetList(idStudent, idSubject, year);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Model.Student student = (Model.Student)comboBoxInsertStudent.SelectedItem;
            Model.Subject subject = (Model.Subject)comboBoxInsertSubject.SelectedItem;
            int year = String.IsNullOrWhiteSpace(textBoxInsertYear.Text) ? 0 : int.Parse(textBoxInsertYear.Text);

            if (student != null && subject != null && year > 0)
            {
                string messageResult = BReportCard.Insert(new Model.ReportCard() { Year = year, IdSubject = subject.Id, IdStudent = student.Id });
                MessageBox.Show(messageResult);
                DataReload("insert");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Model.Student student = (Model.Student)comboBoxUpdateStudent.SelectedItem;
            Model.Subject subject = (Model.Subject)comboBoxUpdateSubject.SelectedItem;
            int year = String.IsNullOrWhiteSpace(textBoxUpdateYear.Text) ? 0 : int.Parse(textBoxUpdateYear.Text);
            int quarter = comboBoxUpdateQuarter.SelectedItem != null ? (int)comboBoxUpdateQuarter.SelectedValue : 0;
            int value = String.IsNullOrWhiteSpace(textBoxUpdateValue.Text) ? 0 : int.Parse(textBoxUpdateValue.Text);

            if (student != null && subject != null && year > 0 && quarter > 0 && value > 0)
            {
                string messageResult = String.Empty;
                switch (quarter)
                {
                    case 1:
                        messageResult = BReportCard.UpdateQuarter(new Model.ReportCard() { Year = year, IdStudent = student.Id, IdSubject = subject.Id, Quarter1=value }, quarter);
                        break;
                    case 2:
                        messageResult = BReportCard.UpdateQuarter(new Model.ReportCard() { Year = year, IdStudent = student.Id, IdSubject = subject.Id, Quarter2 = value }, quarter);
                        break;
                    case 3:
                        messageResult = BReportCard.UpdateQuarter(new Model.ReportCard() { Year = year, IdStudent = student.Id, IdSubject = subject.Id, Quarter3 = value }, quarter);
                        break;
                    case 4:
                        messageResult = BReportCard.UpdateQuarter(new Model.ReportCard() { Year = year, IdStudent = student.Id, IdSubject = subject.Id, Quarter4 = value }, quarter);
                        break;
                    case 5:
                        messageResult = BReportCard.UpdateQuarter(new Model.ReportCard() { Year = year, IdStudent = student.Id, IdSubject = subject.Id, Final = value }, quarter);
                        break;
                }
                MessageBox.Show(messageResult);
                DataReload("update");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Model.Student student = (Model.Student)comboBoxDeleteStudent.SelectedItem;
            Model.Subject subject = (Model.Subject)comboBoxDeleteSubject.SelectedItem;
            int year = String.IsNullOrWhiteSpace(textBoxDeleteYear.Text) ? 0 : int.Parse(textBoxDeleteYear.Text);
            if (student != null && subject != null && year > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete report card of '" + student.Name + "'?", "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string messageResult = BReportCard.Delete(new Model.ReportCard() { Year = year, IdSubject = subject.Id, IdStudent = student.Id });
                    MessageBox.Show(messageResult);
                    DataReload("delete");
                }
            }
        }

        private void comboBoxInsertCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Course c = (Model.Course)comboBoxInsertCourse.SelectedItem;
            if (c != null)
            {
                comboBoxInsertStudent.DataSource = null;
                comboBoxInsertStudent.DataSource = new Business.Student().GetList(c.Id);
                comboBoxInsertStudent.ValueMember = "Id";
                comboBoxInsertStudent.DisplayMember = "Name";
                comboBoxInsertStudent.SelectedItem = null;
            }
            DataReload("insert");
        }

        private void comboBoxInsertSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload("insert");
        }

        private void comboBoxInsertStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload("insert");
        }

        private void comboBoxUpdateCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Course c = (Model.Course)comboBoxUpdateCourse.SelectedItem;
            if (c != null)
            {
                comboBoxUpdateStudent.DataSource = null;
                comboBoxUpdateStudent.DataSource = new Business.Student().GetList(c.Id);
                comboBoxUpdateStudent.ValueMember = "Id";
                comboBoxUpdateStudent.DisplayMember = "Name";
                comboBoxUpdateStudent.SelectedItem = null;
            }
            DataReload("update");
        }

        private void comboBoxUpdateStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload("update");
        }

        private void comboBoxUpdateSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload("update");
        }

        private void comboBoxUpdateQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Student student = (Model.Student)comboBoxUpdateStudent.SelectedItem;
            Model.Subject subject = (Model.Subject)comboBoxUpdateSubject.SelectedItem;
            int year = String.IsNullOrWhiteSpace(textBoxUpdateYear.Text) ? 0 : int.Parse(textBoxUpdateYear.Text);
            int quarter = comboBoxUpdateQuarter.SelectedItem != null ? ((Quarter)comboBoxUpdateQuarter.SelectedItem).Id : 0;
            
            if (student != null && subject != null && year > 0 && quarter > 0)
            {
                Model.ReportCard rc = BReportCard.Get(year, student.Id, subject.Id);
                switch (quarter)
                {
                    case 1:
                        textBoxUpdateValue.Text = "" + rc.Quarter1;
                        break;
                    case 2:
                        textBoxUpdateValue.Text = "" + rc.Quarter2;
                        break;
                    case 3:
                        textBoxUpdateValue.Text = "" + rc.Quarter3;
                        break;
                    case 4:
                        textBoxUpdateValue.Text = "" + rc.Quarter4;
                        break;
                    case 5:
                        textBoxUpdateValue.Text = "" + rc.Final;
                        break;
                }
            }
        }

        private void comboBoxDeleteCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Course c = (Model.Course)comboBoxDeleteCourse.SelectedItem;
            if (c != null)
            {
                comboBoxDeleteStudent.DataSource = null;
                comboBoxDeleteStudent.DataSource = new Business.Student().GetList(c.Id);
                comboBoxDeleteStudent.ValueMember = "Id";
                comboBoxDeleteStudent.DisplayMember = "Name";
                comboBoxDeleteStudent.SelectedItem = null;
            }
            DataReload("delete");
        }

        private void comboBoxDeleteStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload("delete");
        }

        private void comboBoxDeleteSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload("delete");
        }

        private void textBoxDeleteYear_TextChanged(object sender, EventArgs e)
        {
            DataReload("delete");
        }

        private void textBoxUpdateYear_TextChanged(object sender, EventArgs e)
        {
            DataReload("update");
        }

        private void textBoxInsertYear_TextChanged(object sender, EventArgs e)
        {
            DataReload("insert");
        }
    }

    class Quarter
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
