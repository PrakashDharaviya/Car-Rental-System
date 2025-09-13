using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View
{
    public partial class Login : System.Web.UI.Page
    {
        string usname;
            Models.Funtions conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Funtions();
        }
        public static string Cname = "";
        public static int CustId;
        protected void LoginTb_Click(object sender, EventArgs e)
        {
            if (AdminRDB.Checked)
            {
                if (Uname.Value == "Admin" && Upass.Value == "Admin")
                {
                    Cname = "Admin";
                    Response.Redirect("Admin/Home.aspx");
                    Uname.Value = "";
                }
                else 
                {
                    InfoMsg.InnerText = "Invalid Admin.!";
                    Uname.Value = "";
                }
                
            }
            else
            {
                string qry = "select CustName,CustPass,CustId from Tbl_Customer where CustName = '{0}' and CustPass = '{1}'";
                qry = string.Format(qry, Uname.Value, Upass.Value);
                DataTable dt = conn.GetData(qry);
                if (dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid Customer.!";
                }
                else
                {
                    Cname = dt.Rows[0][0].ToString(); // Fetching the username
                    CustId = Convert.ToInt32(dt.Rows[0][2].ToString()); // Fetching the user ID

                    Session["CustName"] = Cname; // Store the correct username in session

                    Response.Redirect("Customer/Cars.aspx"); // Redirecting after login
                }
            }
        }
    }
}