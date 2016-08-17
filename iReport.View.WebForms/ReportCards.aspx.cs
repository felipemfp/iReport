using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iReport.View.WebForms
{
    public partial class ReportCards : System.Web.UI.Page
    {
        private Business.ReportCard BReportCard;

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            BReportCard = new Business.ReportCard();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_DataBound(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string messageResult = BReportCard.Insert(new Model.ReportCard()
            {
                Year = int.Parse(TextBoxYear.Text),
                IdStudent = int.Parse(DropDownList1.SelectedValue),
                IdSubject = int.Parse(DropDownListSubject.SelectedValue)
            });
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int quarter = int.Parse(DropDownList4.SelectedValue);
            Model.ReportCard rc = new Model.ReportCard()
            {
                Year = int.Parse(TextBoxUpYear.Text),
                IdStudent = int.Parse(DropDownList1.SelectedValue),
                IdSubject = int.Parse(DropDownList3.SelectedValue)
            }; 
            switch (quarter)
            {
                case 1:
                    rc.Quarter1 = int.Parse(TextBoxUpValue.Text);
                    break;
                case 2:
                    rc.Quarter2 = int.Parse(TextBoxUpValue.Text);
                    break;
                case 3:
                    rc.Quarter3 = int.Parse(TextBoxUpValue.Text);
                    break;
                case 4:
                    rc.Quarter4 = int.Parse(TextBoxUpValue.Text);
                    break;
                case 5:
                    rc.Final = int.Parse(TextBoxUpValue.Text);
                    break;
            }
            string messageResult = BReportCard.UpdateQuarter(rc, quarter);
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Model.ReportCard rc = new Model.ReportCard() 
            { 
                Year = int.Parse(TextBoxUpYear.Text), 
                IdStudent = int.Parse(DropDownList1.SelectedValue), 
                IdSubject = int.Parse(DropDownList3.SelectedValue)
            };
            string messageResult = BReportCard.Delete(rc);
            Response.Write("<script>alert('" + messageResult + "')</script>");
            DataBind();            
        }

        protected void DropDownList4_DataBound(object sender, EventArgs e)
        {
            Model.ReportCard rc = BReportCard.Get(int.Parse(TextBoxUpYear.Text), int.Parse(DropDownList1.SelectedValue), int.Parse(DropDownList3.SelectedValue));

            if (rc != null)
            {
                switch (DropDownList4.SelectedValue)
                {
                    case "1":
                        TextBoxUpValue.Text = rc.Quarter1.ToString();
                        break;
                    case "2":
                        TextBoxUpValue.Text = rc.Quarter2.ToString();
                        break;
                    case "3":
                        TextBoxUpValue.Text = rc.Quarter3.ToString();
                        break;
                    case "4":
                        TextBoxUpValue.Text = rc.Quarter4.ToString();
                        break;
                    case "5":
                        TextBoxUpValue.Text = rc.Final.HasValue ? rc.Final.Value.ToString() : String.Empty;
                        break;
                }
            }
        }
    }
}