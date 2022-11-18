using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.user
{
    public partial class register : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.name = TextBox1.Text;
            objdpt1.email = TextBox2.Text;
            objdpt1.phone_no = TextBox3.Text;
            objdpt1.password = TextBox4.Text;
            int i = objdpt1.insertdepartment();
            int j= objdpt1.insertLogin();
            if (i == 1)
            {
                Response.Write("sucess");
            }
            else
            {
                Response.Write("failed");

            }
        }
    }
} 