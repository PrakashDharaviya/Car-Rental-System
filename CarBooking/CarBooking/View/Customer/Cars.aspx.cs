using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View.Customer
{
    public partial class Cars : System.Web.UI.Page
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
            string st = "Availabel";
            string qry = "select * from Tbl_Car where Status = '"+ st +"'";
            CarList.DataSource = conn.GetData(qry);
            CarList.DataBind();
        }

        private void UpdateCar()
        { 
             try
            {
                
                    string Status = "Booked";
                    string qry = "update Tbl_Car set Status='{0}' where CPlateNum='{1}'";
                    qry = String.Format(qry, Status, CarList.SelectedRow.Cells[1].Text);
                    conn.SetData(qry);
                    Dispaly();
                }
            
            catch (Exception Ex)
            {
                //throw;
                //InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void BookingTb_Click1(object sender, EventArgs e)
        {

            TimeSpan DDay = Convert.ToDateTime(Bdate.Value) - System.DateTime.Today.Date;
            int Days = DDay.Days;
            int DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[4].Text);    
            int Fees = DPrice * Days;

            try
            {
                if (CarList.SelectedRow.Cells[1].Text == "")
                {
                    InfoMsg.InnerText = "Missing Information..!";
                }
                else
                {
                    
                    string qry = "insert into Tbl_Rental values('{0}',{1},'{2}','{3}',{4})";
                    qry = String.Format(qry, CarList.SelectedRow.Cells[1].Text, default.CustId,System.DateTime.Today.Date.ToString(), Bdate.Value, Fees);
                    conn.SetData(qry);

                    UpdateCar();
                    Dispaly();
                    
                    InfoMsg.InnerText = "Car Rented Successfully";
                    
                }
            }
            catch (Exception Ex)
            {
                //throw;
                //InfoMsg.InnerText = Ex.Message;
            }
            Dispaly();
            UpdateCar();
        }

        string LnumTb, RentDate, ReturnDate;
        int DPrice,Customer;
        
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LnumTb = CarList.SelectedRow.Cells[1].Text;    
            RentDate = System.DateTime.Today.Date.ToString();
            ReturnDate = Bdate.Value;
            DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[4].Text);

            InfoMsg.InnerText = CarList.SelectedRow.Cells[1].Text;
        }
        
    }
}