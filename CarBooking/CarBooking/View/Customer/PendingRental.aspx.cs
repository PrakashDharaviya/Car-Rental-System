using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View.Customer
{
    public partial class PendingRents : System.Web.UI.Page
    {
        Models.Funtions conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Funtions();
            Dispaly();
           
        }
        public override void VerifyRenderingInServerForm(Control control)
        {


        }


        private void Dispaly()
        {
            
            string qry = "select * from Tbl_Rental where CustId = '" + Login.CustId + "'";
            CarList.DataSource = conn.GetData(qry);
            CarList.DataBind();
        }

    }
}