using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iReport.View.WebForms
{
    public partial class Subjects : System.Web.UI.Page
    {
        private Business.Subject BSubject;

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            BSubject = new Business.Subject();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string messageResult = BSubject.Insert(new Model.Subject() { Description = TextBox1.Text });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string messageResult = BSubject.Update(new Model.Subject()
            {
                Id = int.Parse(DropDownList1.SelectedValue),
                Description = TextBox2.Text
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string messageResult = BSubject.Delete(new Model.Subject()
            {
                Id = int.Parse(DropDownList1.SelectedValue)
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }
    }
}