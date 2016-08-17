using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iReport.View.WebForms
{
    public partial class Students : System.Web.UI.Page
    {
        private Business.Student BStudent;

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            BStudent = new Business.Student();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string messageResult = BStudent.Insert(new Model.Student() 
            { 
                IdCourse = int.Parse(DropDownList1.SelectedValue),
                Name = TextBoxName.Text,
                Email = TextBoxEmail.Text,
                Phone = TextBoxPhone.Text,
                Birth = DateTime.Parse(TextBoxBirth.Text)
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string messageResult = BStudent.Update(new Model.Student()
            {
                Id = int.Parse(DropDownList2.SelectedValue),
                Name = TextBoxNewName.Text,
                Email = TextBoxNewEmail.Text,
                Phone = TextBoxNewPhone.Text,
                Birth = DateTime.Parse(TextBoxNewBirth.Text),
                IdCourse = int.Parse(DropDownList1.SelectedValue)
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string messageResult = BStudent.Delete(new Model.Student()
            {
                Id = int.Parse(DropDownList2.SelectedValue)
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedValue!=null && !String.IsNullOrWhiteSpace(DropDownList2.SelectedValue))
            {
                Model.Student s = BStudent.Get(int.Parse(DropDownList2.SelectedValue));
                TextBoxNewName.Text = s.Name;
                TextBoxNewEmail.Text = s.Email;
                TextBoxNewBirth.Text = String.Format("{0}/{1}/{2}",s.Birth.Day, s.Birth.Month, s.Birth.Year);
                TextBoxNewPhone.Text = s.Phone;                
            }
        }
    }
}