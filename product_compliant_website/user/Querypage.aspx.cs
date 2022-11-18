using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.user
{
    public partial class Querypage : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Dd2.DataSource = objdpt1.GetProduct();
            Dd2.DataTextField = "productname";
            Dd2.DataValueField = "pid";
            Dd2.DataBind();

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            objdpt1.pid = int.Parse(Dd2.SelectedItem.Value);
            objdpt1.query = Request.Form["TextArea1"];
            objdpt1.Login = Convert.ToString(Session["id"]);
            objdpt1.name = Convert.ToString(Session["uname"]);
            int i = objdpt1.insertquery();
            if (i == 1)
            {
                Response.Write("<script>alert('query sucessfully Send ');</script>");
            }
            else
            {
                Response.Write("failed");

            }

        }
    }
}