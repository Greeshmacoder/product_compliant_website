using product_compliant_website.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.user
{
    public partial class Complaint_page : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource = objdpt1.userproduct();
           // GridView1.DataBind();
           if(!IsPostBack)
            {

                DropDownList1.DataSource = objdpt1.GetProduct();
                DropDownList1.DataTextField = "productname";
                DropDownList1.DataValueField = "pid";
                DropDownList1.DataBind();


            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.pid = int.Parse(DropDownList1.SelectedItem.Value);
            objdpt1.complaint = Request.Form["TextArea1"];
            objdpt1.Login = Convert.ToString(Session["id"]);
            objdpt1.name = Convert.ToString(Session["uname"]);


            int i = objdpt1.insertcompliant();
            if (i == 1)
            {
                Response.Write("<script>alert('Compliant Registered sucessfully');</script>");
            }
            else
            {
                Response.Write("failed");

            }

        }
    }
}