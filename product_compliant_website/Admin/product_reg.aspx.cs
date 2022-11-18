using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.Admin
{
    public partial class product_reg : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.productname = TextBox1.Text;
            objdpt1.price = TextBox2.Text;
            int i = objdpt1.insertProduct();
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