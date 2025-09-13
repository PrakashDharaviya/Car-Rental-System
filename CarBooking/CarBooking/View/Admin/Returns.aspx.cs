using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View.Admin
{
    public partial class Returns : System.Web.UI.Page
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

            string qry = "select * from Tbl_Return";
            RentList.DataSource = conn.GetData(qry);
            RentList.DataBind();
        }

    }
}