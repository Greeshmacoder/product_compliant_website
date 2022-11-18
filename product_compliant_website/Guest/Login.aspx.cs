using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.name = TextBox2.Text;
            objdpt1.password = TextBox1.Text;
            DataTable dt = objdpt1.LoginPage();
            if (dt.Rows.Count > 0)
            {
                Session["uname"] = dt.Rows[0]["username"];
                Session["id"] = dt.Rows[0]["lId"];
                if (dt.Rows[0][3].ToString() == "Admin")
                {

                    Response.Redirect("../Admin/AdminContent.aspx");
                }

                else if (dt.Rows[0][3].ToString() == "User" && dt.Rows[0][4].ToString() == "confirm")
                {
                    Response.Redirect("../user/WebForm1.aspx");


                }
                else if (dt.Rows[0][3].ToString() == "User" && dt.Rows[0][4].ToString() != "confirm")
                {
                    Response.Write("<script>alert('User Not Verified by Admin');</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('Incorrect username or password');</script>");
            }
            
        }
    }
}