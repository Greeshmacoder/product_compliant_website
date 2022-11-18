using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace product_compliant_website.DAL
{
    public class ProDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ProDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }

        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int deptmentInsert(BAL.ProBAL obj)
        {
            string qry = "insert into tlb_reg values ('" + obj.name + "','" + obj.phone_no + "','" + obj.email + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int insertLogin(BAL.ProBAL obj)
        {
            string qry1 = "insert into tlb_login values ('" + obj.name + "','" + obj.password + "','User','Not_confirmed')";
            SqlCommand cmd = new SqlCommand(qry1, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int Productinsert(BAL.ProBAL obj)
        {
            string qry2 = "insert into tbl_product values ('" + obj.productname + "'," + obj.price + ")";
            SqlCommand cmd = new SqlCommand(qry2, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable Viewuser()
        {
            string s = "Select * from tlb_login where Role ='Not_confirmed'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int userApprove(BAL.ProBAL obj)
        {
            string s = "update tlb_login set Role='confirm' where lid=" + obj.Login;
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable pageLogin(BAL.ProBAL obj)
        {
            string qry3 = "SELECT * FROM tlb_login WHERE username ='" + obj.name + "' AND password='" + obj.password + "'";
            SqlCommand cmd = new SqlCommand(qry3, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        public DataTable Viewproduct()
        {
            string s = "Select * from tbl_product";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int compliant(BAL.ProBAL obj)
        {
            string qry = "insert into tlb_complaint(user_id,username,complaint,pid,status,date) values ('" + obj.Login + "','" + obj.name + "','" + obj.complaint + "','" + obj.pid + "','NotYet',GETDATE())";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();

        }
        public int Productquery(BAL.ProBAL obj)
        {
            string qry = "insert into tlb_query(pid,username,user_id,query) values ('" + obj.pid + "','" + obj.name + "','" + obj.Login + "','" + obj.query + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();

        }
        public DataTable GetProductDetails(BAL.ProBAL obj)
        {
            string s = "Select * from tbl_product ";
            SqlCommand cmd = new SqlCommand(s, Getcon());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable queryDetails(BAL.ProBAL obj)
        {
            string s = "Select * from tlb_query ";
            SqlCommand cmd = new SqlCommand(s, Getcon());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable Viewcompliant(BAL.ProBAL obj)
        {
            string s = "Select * from tlb_complaint where status='NotYet' AND date >='" + obj.from + "' AND date<='" + obj.To + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Viewquery()
        {
            string s = "Select * from tlb_query ";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintApprove(BAL.ProBAL obj)
        {
            string s = "update tlb_complaint set status ='InProgress' where cid= '" + obj.cid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable proceesComplaint(BAL.ProBAL obj)
        {
            string s = "Select * from tlb_complaint where status='Inprogress' AND  date >='" + obj.from + "' AND date<='" + obj.To + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Closedcomplaint(BAL.ProBAL obj)
        {
            string s = "update tlb_complaint set status ='closed' where cid= '" + obj.cid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
       
        public int complaintclose(BAL.ProBAL obj)
        {
            string s = "update tlb_complaint set Status='Closed' where Cid='" + obj.cid + "'"; 
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }

        public DataTable viewclosed()
        {
            string s = "Select * from tlb_query";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Viewqueryy()
        {
            string s = "Select * from tlb_complaint where Status='Closed'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }

}
