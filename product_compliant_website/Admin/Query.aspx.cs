using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product_compliant_website.Admin
{
    public partial class Query : System.Web.UI.Page
    {
        BAL.ProBAL objdpt1 = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int qid = Convert.ToInt32(Request.QueryString["query_id"]);
                Session["queryid"] = qid;
                objdpt1.query_id = qid;
                DataTable dt = objdpt1.ViewSpecificQuery();
                if (dt != null)
                {
                    PRoductTextBox1.Text = dt.Rows[0]["productname"].ToString();
                    QuestionTextBox.Text = dt.Rows[0]["query"].ToString();



                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.Reply = ReplyTextBox.Text;
            int queryid = Convert.ToInt32(Session["queryid"]);
            objdpt1.query_id= queryid;
            int i = objdpt1.GiveReply();
            if (i == 1)
            {
                Response.Write("<script>alert('Replyed Successfully ');</script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Replyed Successfully" + "');", true);
                Response.Redirect("../Admin/query_reply.aspx");



            }
        }
    }
}