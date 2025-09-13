using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View.Admin
{
    public partial class Rental : System.Web.UI.Page
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

            string qry = "select * from Tbl_Rental";
            RentList.DataSource = conn.GetData(qry);
            RentList.DataBind();
        }

        private void UpdateCar()
        {
            try
            {

                string Status = "Availabel";
                string qry = "update Tbl_Car set Status='{0}' where CPlateNum='{1}'";
                qry = String.Format(qry, Status, RentList.SelectedRow.Cells[2].Text);
                conn.SetData(qry);
                Dispaly();
            }

            catch (Exception Ex)
            {
                //throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }

        public void ReturnCar()
        {
            try
            {                    
                    string qry = "delete from Tbl_Rental where RentId={0}";
                    qry = String.Format(qry, RentList.SelectedRow.Cells[1].Text);
                    conn.SetData(qry);
                    Dispaly();
            }
            catch (Exception )
            {
                //throw;
                //ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void ReturnTb_Click(object sender, EventArgs e)
        {

            try
            {
                if (RentList.SelectedRow.Cells[1].Text == "")
                {
                    InfoMsg.InnerText = "Select A RentCar";
                }
                else
                {

                    string qry = "insert into Tbl_Return values('{0}',{1},'{2}','{3}',{4})";
                    qry = String.Format(qry, RentList.SelectedRow.Cells[2].Text, RentList.SelectedRow.Cells[3].Text, System.DateTime.Today.Date.ToString(), DelayTb.Value,FineTb.Value);
                    conn.SetData(qry);

                    UpdateCar();
                    ReturnCar();
                    Dispaly();

                    InfoMsg.InnerText = "Car Returned Successfully";

                }
            }
            catch (Exception Ex)
            {
                //throw;
                InfoMsg.InnerText = "Select A RentedCar";
            }
            Dispaly();

        }

        string Licence;
        protected void RentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Licence = RentList.SelectedRow.Cells[1].Text;

            InfoMsg.InnerText = RentList.SelectedRow.Cells[1].Text;
        }
    }
}