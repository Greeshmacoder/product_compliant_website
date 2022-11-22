using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.user
{
    public partial class query_grid : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdpt1.closedviewqyery();
                GridView1.DataBind();
            }

        }
    }
}