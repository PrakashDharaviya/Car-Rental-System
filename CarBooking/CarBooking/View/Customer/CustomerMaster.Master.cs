using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace CarBooking.View.Customer
{
    public partial class CustomerMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) // Prevents multiple assignments on postbacks
            {
                if (Session["CustName"] != null && !string.IsNullOrEmpty(Session["CustName"].ToString()))
                {
                    CustName.Text =  Session["CustName"].ToString(); // Debugging
                }
                else
                {
                    CustName.Text = "Guest";
                }
            }
        }
    }
}