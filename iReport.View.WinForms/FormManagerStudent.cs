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
    public partial class FormManagerStudent : Form
    {
        private Business.Student BStudent;

        public FormManagerStudent()
        {
            InitializeComponent();
            BStudent = new Business.Student();
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = BStudent.GetList();
        }

        private void FormManagerStudent_Shown(object sender, EventArgs e)
        {
            Business.Course BCourse = new Business.Course();
            comboBoxUpdateCourses.DataSource = BCourse.GetList();
            comboBoxUpdateCourses.ValueMember = "Id";
            comboBoxUpdateCourses.DisplayMember = "Description";
            comboBoxInsertCourse.DataSource = BCourse.GetList();
            comboBoxInsertCourse.ValueMember = "Id";
            comboBoxInsertCourse.DisplayMember = "Description";
            comboBoxUpdateCourse.DataSource = BCourse.GetList();
            comboBoxUpdateCourse.ValueMember = "Id";
            comboBoxUpdateCourse.DisplayMember = "Description";
        }

        private void DataReload()
        {
            int idCourse = comboBoxInsertCourse.SelectedItem != null ? ((Model.Course)comboBoxInsertCourse.SelectedItem).Id : 0;
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = BStudent.GetList(idCourse);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (comboBoxInsertCourse.SelectedValue != null)
            {
                string messageResult = BStudent.Insert(new Model.Student() 
                { 
                    Name = textBoxInsertName.Text, 
                    Email = textBoxInsertEmail.Text,
                    Phone = textBoxInsertPhone.Text,
                    Birth = dateTimePickerBirth.Value,
                    IdCourse = (int)comboBoxInsertCourse.SelectedValue
                });
                MessageBox.Show(messageResult);
                DataReload();                
            }
        }

        private void comboBoxInsertCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload();
        }

        private void comboBoxUpdateCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataReload();
            int idCourse = comboBoxUpdateCourses.SelectedItem != null ? ((Model.Course)comboBoxUpdateCourses.SelectedItem).Id : 0;
            comboBoxUpdateStudents.DataSource = null;
            comboBoxUpdateStudents.DataSource = BStudent.GetList(idCourse);
            comboBoxUpdateStudents.ValueMember = "Id";
            comboBoxUpdateStudents.DisplayMember = "Name";
        }

        private void comboBoxUpdateStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateStudents.SelectedItem!=null)
            {
                
            Model.Student s = (Model.Student)comboBoxUpdateStudents.SelectedItem;
            comboBoxUpdateCourse.SelectedValue = s.IdCourse;
            textBoxUpdateName.Text = s.Name;
            textBoxUpdateEmail.Text = s.Email;
            textBoxUpdatePhone.Text = s.Phone;
            dateTimePickerUpdateBirth.Value = s.Birth;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxUpdateStudents.SelectedValue != null && comboBoxUpdateCourse.SelectedValue!=null)
            {
                string messageResult = BStudent.Update(new Model.Student() { Id = (int)comboBoxUpdateStudents.SelectedValue, IdCourse = (int)comboBoxUpdateCourse.SelectedValue, Name = textBoxUpdateName.Text, Phone = textBoxUpdatePhone.Text, Email = textBoxUpdateEmail.Text, Birth = dateTimePickerUpdateBirth.Value });
                MessageBox.Show(messageResult);
                DataReload();
            }
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Model.Student c = (Model.Student)comboBoxUpdateStudents.SelectedItem;
            if (c != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete '" + c.Name + "'?", "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string messegeResult = BStudent.Delete(c);
                    MessageBox.Show(messegeResult);
                    DataReload();

                    /* Reload */
                    int idCourse = comboBoxUpdateCourses.SelectedItem != null ? ((Model.Course)comboBoxUpdateCourses.SelectedItem).Id : 0;
                    comboBoxUpdateStudents.DataSource = null;
                    comboBoxUpdateStudents.DataSource = BStudent.GetList(idCourse);
                    comboBoxUpdateStudents.ValueMember = "Id";
                    comboBoxUpdateStudents.DisplayMember = "Name";
                }
            }
        }
    }
}
