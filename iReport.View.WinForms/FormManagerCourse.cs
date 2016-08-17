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
    public partial class FormManagerCourse : Form
    {
        private Business.Course BCourse;

        public FormManagerCourse()
        {
            InitializeComponent();
            BCourse = new Business.Course();
            dataGridViewCourses.DataSource = null;
            dataGridViewCourses.DataSource = BCourse.GetList();
        }

        private void DataReload()
        {
            dataGridViewCourses.DataSource = null;
            comboBoxDeleteCourses.DataSource = null;
            comboBoxUpdateCourses.DataSource = null;
            dataGridViewCourses.DataSource = BCourse.GetList();
            comboBoxUpdateCourses.DataSource = BCourse.GetList();
            comboBoxUpdateCourses.ValueMember = "Id";
            comboBoxUpdateCourses.DisplayMember = "Description";
            comboBoxDeleteCourses.DataSource = BCourse.GetList();
            comboBoxDeleteCourses.ValueMember = "Id";
            comboBoxDeleteCourses.DisplayMember = "Description";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string messageResult = BCourse.Insert(new Model.Course() { Description = textBoxInsertDescription.Text });
            MessageBox.Show(messageResult);
            DataReload();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxUpdateCourses.SelectedValue != null)
            {                
                string messageResult = BCourse.Update(new Model.Course() { Id = (int)comboBoxUpdateCourses.SelectedValue, Description = textBoxUpdateDescription.Text });
                MessageBox.Show(messageResult);
                DataReload();
            }
        }

        private void FormManagerCourse_Shown(object sender, EventArgs e)
        {
            comboBoxUpdateCourses.DataSource = BCourse.GetList();
            comboBoxUpdateCourses.ValueMember = "Id";
            comboBoxUpdateCourses.DisplayMember = "Description";
            comboBoxDeleteCourses.DataSource = BCourse.GetList();
            comboBoxDeleteCourses.ValueMember = "Id";
            comboBoxDeleteCourses.DisplayMember = "Description";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Model.Course c = (Model.Course)comboBoxDeleteCourses.SelectedItem;
            if (c != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete '" + c.Description + "'?", "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string messegeResult = BCourse.Delete(c);
                    MessageBox.Show(messegeResult);
                    DataReload();
                }
            }            
        }
    }
}
