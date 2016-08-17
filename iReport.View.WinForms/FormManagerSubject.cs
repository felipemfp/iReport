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
    public partial class FormManagerSubject : Form
    {
        private Business.Subject BSubject;

        public FormManagerSubject()
        {
            InitializeComponent();
            BSubject = new Business.Subject();
            dataGridViewSubjects.DataSource = null;
            dataGridViewSubjects.DataSource = BSubject.GetList();
        }

        private void DataReload()
        {
            dataGridViewSubjects.DataSource = null;
            comboBoxDeleteSubjects.DataSource = null;
            comboBoxUpdateSubjects.DataSource = null;
            dataGridViewSubjects.DataSource = BSubject.GetList();
            comboBoxUpdateSubjects.DataSource = BSubject.GetList();
            comboBoxUpdateSubjects.ValueMember = "Id";
            comboBoxUpdateSubjects.DisplayMember = "Description";
            comboBoxDeleteSubjects.DataSource = BSubject.GetList();
            comboBoxDeleteSubjects.ValueMember = "Id";
            comboBoxDeleteSubjects.DisplayMember = "Description";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string messageResult = BSubject.Insert(new Model.Subject() { Description = textBoxInsertDescription.Text });
            MessageBox.Show(messageResult);
            DataReload();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxUpdateSubjects.SelectedValue!=null)
            {                
            string messageResult = BSubject.Update(new Model.Subject() { Id = (int)comboBoxUpdateSubjects.SelectedValue, Description = textBoxUpdateDescription.Text });
            MessageBox.Show(messageResult);
            DataReload();
            }
        }

        private void FormManagerSubject_Shown(object sender, EventArgs e)
        {
            comboBoxUpdateSubjects.DataSource = BSubject.GetList();
            comboBoxUpdateSubjects.ValueMember = "Id";
            comboBoxUpdateSubjects.DisplayMember = "Description";
            comboBoxDeleteSubjects.DataSource = BSubject.GetList();
            comboBoxDeleteSubjects.ValueMember = "Id";
            comboBoxDeleteSubjects.DisplayMember = "Description";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Model.Subject c = (Model.Subject)comboBoxDeleteSubjects.SelectedItem;
            if (c!=null)
            {
                var result = MessageBox.Show("Are you sure you want to delete '" + c.Description + "'?", "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string messegeResult = BSubject.Delete(c);
                    MessageBox.Show(messegeResult);
                    DataReload();
                }
            }
            
        }
    }
}
