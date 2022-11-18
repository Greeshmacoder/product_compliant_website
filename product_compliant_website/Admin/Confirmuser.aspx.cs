using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.Admin
{
    public partial class Confirmuser : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdpt1.userview();
                GridView1.DataBind();
            }

        }

       
        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objdpt1.Login = id.ToString();
            int i = objdpt1.updateuser();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdpt1.userview();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}