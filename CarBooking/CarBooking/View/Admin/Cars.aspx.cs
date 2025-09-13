using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View.Admin
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

        private void Dispaly() {
            string qry = "select * from Tbl_Car";
            CarList.DataSource = conn.GetData(qry);
            CarList.DataBind();
        }

        protected void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LnumTb.Value == "" || BrandTb.Value == "" || ModelTb.Value == "" || PriceTb.Value == "" || ColorTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information..!";
                }
                else {
                    string PlateNum = LnumTb.Value;
                    string Brand = BrandTb.Value;
                    string Model = ModelTb.Value;
                    int Price = Convert.ToInt32(PriceTb.Value.ToString());
                    string Color = ColorTb.Value;
                    string Status = AvaiCb.SelectedValue;
                    string qry = "insert into Tbl_Car values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    qry = String.Format(qry,PlateNum, Brand, Model, Price, Color, Status);
                    conn.SetData(qry);
                    Dispaly();
                    ErrorMsg.InnerText = "Car Added Successfully";
                    LnumTb.Value = ""; BrandTb.Value = ""; ModelTb.Value = ""; PriceTb.Value = ""; ColorTb.Value = "";
                }
            }
            catch(Exception Ex) { 
            //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LnumTb.Value = CarList.SelectedRow.Cells[1].Text;
            BrandTb.Value = CarList.SelectedRow.Cells[2].Text;
            ModelTb.Value = CarList.SelectedRow.Cells[3].Text;
            PriceTb.Value = CarList.SelectedRow.Cells[4].Text;
            ColorTb.Value = CarList.SelectedRow.Cells[5].Text;
            AvaiCb.SelectedValue = CarList.SelectedRow.Cells[6].Text;

            ErrorMsg.InnerText = CarList.SelectedRow.Cells[1].Text;
        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LnumTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information..!";
                }
                else
                {
                    string PlateNum = LnumTb.Value;
                    string qry = "delete from Tbl_Car where CPlateNum='{0}'";
                    qry = String.Format(qry, PlateNum);
                    conn.SetData(qry);
                    Dispaly();
                    ErrorMsg.InnerText = "Car Deleted Successfully";
                    LnumTb.Value = ""; BrandTb.Value = ""; ModelTb.Value = ""; PriceTb.Value = ""; ColorTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LnumTb.Value == "" || BrandTb.Value == "" || ModelTb.Value == "" || PriceTb.Value == "" || ColorTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information..!";
                }
                else
                {
                    string PlateNum = LnumTb.Value;
                    string Brand = BrandTb.Value;
                    string Model = ModelTb.Value;
                    int Price = Convert.ToInt32(PriceTb.Value.ToString());
                    string Color = ColorTb.Value;
                    string Status = AvaiCb.SelectedValue;
                    string qry = "update Tbl_Car set Brand='{0}',Model='{1}',Price={2},Color='{3}',Status='{4}' where CPlateNum='{5}'";
                    qry = String.Format(qry, Brand, Model, Price, Color, Status, PlateNum);
                    conn.SetData(qry);
                    Dispaly();
                    ErrorMsg.InnerText = "Car Updated Successfully";
                    LnumTb.Value = ""; BrandTb.Value = ""; ModelTb.Value = ""; PriceTb.Value = ""; ColorTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }
    }
}