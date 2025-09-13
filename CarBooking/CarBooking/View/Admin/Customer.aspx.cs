using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarBooking.View.Admin
{
    public partial class Customer : System.Web.UI.Page
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
            string qry = "select * from Tbl_Customer";
            CustList.DataSource = conn.GetData(qry);
            CustList.DataBind();
        }

        protected void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Value == "" || PhoneTb.Value == "" || AddTb.Value == "" || PassTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information..!";
                }
                else
                {
                    string CustName = CustNameTb.Value;
                    string CustAdd = AddTb.Value;
                    string CustPhone = PhoneTb.Value; 
                    string CustPass = PassTb.Value;
                    string qry = "insert into Tbl_Customer values('{0}','{1}','{2}','{3}')";
                    qry = String.Format(qry, CustName, CustAdd, CustPhone, CustPass);
                    conn.SetData(qry);
                    Dispaly();
                    ErrorMsg.InnerText = "Customer Added Successfully ";
                    CustNameTb.Value = ""; AddTb.Value = ""; PhoneTb.Value = ""; PassTb.Value = "";
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
                if (CustNameTb.Value == "" || PhoneTb.Value == "" || AddTb.Value == "" || PassTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information..!";
                }
               
                else
                {   
                    int CustId = Convert.ToInt32(CustList.SelectedRow.Cells[1].Text);
                    string CustName = CustNameTb.Value;
                    string CustAdd = AddTb.Value;
                    string CustPhone = PhoneTb.Value;
                    string CustPass = PassTb.Value;
                    string qry = "update Tbl_Customer set CustName='{0}',CustAdd='{1}',CustPhone='{2}',CustPass='{3}'where CustId={4}";
                    qry = String.Format(qry, CustName, CustAdd, CustPhone, CustPass ,CustId);
                    conn.SetData(qry);
                    Dispaly();
                    ErrorMsg.InnerText = "Customer Updated Successfully";
                    CustNameTb.Value = ""; AddTb.Value = ""; PhoneTb.Value = ""; PassTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }

        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information..!";
                }
                else
                {
                    
                    string qry = "delete from Tbl_Customer where CustId={0}";
                    qry = String.Format(qry,Convert.ToInt32(CustList.SelectedRow.Cells[1].Text));
                    conn.SetData(qry);
                    Dispaly();
                    ErrorMsg.InnerText = "Customer Deleted Successfully";
                    CustNameTb.Value = ""; AddTb.Value = ""; PhoneTb.Value = ""; PassTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }
        int key = 0;
        protected void CustList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustNameTb.Value = CustList.SelectedRow.Cells[2].Text;
            AddTb.Value = CustList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = CustList.SelectedRow.Cells[4].Text;
            PassTb.Value = CustList.SelectedRow.Cells[5].Text;
            if (CustNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CustList.SelectedRow.Cells[1].Text);
            }
            ErrorMsg.InnerText = " " + key;
        }
    }
}