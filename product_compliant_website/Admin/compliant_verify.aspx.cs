using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.Admin
{
    public partial class compliant_verify : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.from = TextBox1.Text;
            objdpt1.To= TextBox2.Text;
            GridView1.DataSource = objdpt1.compliantView();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objdpt1.cid= id.ToString();
            int i = objdpt1.Closedcomplaint();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdpt1.compliantView();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            objdpt1.from = TextBox1.Text;
            objdpt1.To = TextBox2.Text;
            GridView2.DataSource = objdpt1.complaintProcess();
            GridView2.DataBind();

        }
        

        protected void Button3_Click(object sender, EventArgs e)
        {
            objdpt1.from = TextBox1.Text;
            objdpt1.To = TextBox2.Text;
            GridView2.DataSource = objdpt1.ComplaintClosed();
            GridView2.DataBind();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            objdpt1.cid = id.ToString();
            int i = objdpt1.closecomplaint();
            GridView2.EditIndex = -1;
            GridView2.DataSource = objdpt1.compliantView();
            GridView2.DataBind();
            GridView1.DataBind();

        }


    }
    
}