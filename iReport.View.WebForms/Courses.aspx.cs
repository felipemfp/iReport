using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iReport.View.WebForms
{
    public partial class Courses : System.Web.UI.Page
    {
        private Business.Course BCourse;

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            BCourse = new Business.Course();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string messageResult = BCourse.Insert(new Model.Course() { Description = TextBox1.Text });
            Response.Write("<script>alert('"+messageResult+"')</script>");
            DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string messageResult = BCourse.Update(new Model.Course() 
            { 
                Id = int.Parse(DropDownList1.SelectedValue),
                Description = TextBox2.Text 
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string messageResult = BCourse.Delete(new Model.Course()
            {
                Id = int.Parse(DropDownList1.SelectedValue)
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }
    }
}