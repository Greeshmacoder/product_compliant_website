using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace product_compliant_website.BAL
{
    public class ProBAL
    {
        DAL.ProDAL objdeptd1 = new DAL.ProDAL();

        public string user_id;
        public string _name;
        public string _phone;
        public string _email;
        public string _password;
        public string _productname;
        public string _price;
        public string _login;
        public string _username;
        public int _pid;
        public string _compliant;
        public string _query;
        public string _To;
        public string _from;
        public string _cid;

        public string reg_id
        {
            get
            {
                return user_id;

            }
            set
            {
                reg_id = value;


            }
        }

        public string name
        {
            get
            {
                return _name;

            }
            set
            {
                _name = value;


            }

        }
        public string phone_no
        {
            get
            {
                return _phone;

            }
            set
            {
                _phone = value;


            }
        }
        public string email
        {
            get
            {
                return _email;

            }
            set
            {
                _email = value;


            }
        
        }
        public string password
        {
            get
            {
                return _password;

            }
            set
            {
                _password = value;


            }

        }
        public string productname
        {
            get
            {
                return _productname;

            }
            set
            {
                _productname = value;


            }

        }
        public string price
        {
            get
            {
                return _price;

            }
            set
            {
                _price = value;


            }

        }
        public string Login
        {
            get
            {
                return _login;

            }
            set
            {
                _login = value;


            }
        }
        public string username
        {
            get
            {
                return _username;

            }
            set
            {
                _username= value;


            }
        }
        public int pid
        {
            get
            {
                return _pid;

            }
            set
            {
                _pid = value;


            }
        }
        public string complaint
        {
            get
            {
                return _compliant;

            }
            set
            {
                _compliant = value;


            }
        }
        public string query
        {
            get
            {
                return _query;

            }
            set
            {
                _query= value;


            }
        }
        public string To
        {
            get
            {
                return _To;

            }
            set
            {
                _To = value;


            }

        }
        public string from
        {
            get
            {
                return _from;

            }
            set
            {
                _from = value;


            }
        }
             public string cid
             {
            get
            {
                return _cid;

            }
            set
            {
                _cid = value;


            }
        }



        public int insertdepartment()
        {
            return objdeptd1.deptmentInsert(this);
        }

        public int insertLogin()
        {
            return objdeptd1.insertLogin(this);
        }
        public int insertProduct()
        {
            return objdeptd1.Productinsert(this);
        }
        public DataTable userview()
        {
            return objdeptd1.Viewuser();
        }
        public int updateuser()
        {
            return objdeptd1.userApprove(this);
        }
        public DataTable LoginPage()
        {
            return objdeptd1.pageLogin(this);
        }
        public DataTable userproduct()
        {
            return objdeptd1.Viewproduct();
        }
        public int insertcompliant()
        {
            return objdeptd1.compliant(this);
        }
        public int insertquery()
        {
            return objdeptd1.Productquery(this);
        }
        public DataTable GetProduct()
        {
            return objdeptd1.GetProductDetails(this);
        }
        public DataTable Getquery()
        {
            return objdeptd1.queryDetails(this);
        }
        public DataTable compliantView()
        {
            return objdeptd1.Viewcompliant(this);
        }
        public DataTable queryView()
        {
            return objdeptd1.Viewquery();
        }
        public int Closedcomplaint()
        {
            return objdeptd1.complaintApprove(this);
        }
        public DataTable ComplaintClosed()
        {
            return objdeptd1.proceesComplaint(this);
        }
        public int complaintProcess()
        {
            return objdeptd1.Closedcomplaint(this);
        }
        public int closecomplaint()
        {
            return objdeptd1.complaintclose(this);
        }
        public DataTable queryyview()
        {
            return objdeptd1.Viewqueryy();
        }
        public DataTable closedview()
        {
            return objdeptd1.Viewqueryy();
        }
    }
}


