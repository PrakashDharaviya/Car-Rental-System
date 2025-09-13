using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CarBooking.Models
{
    public class Funtions
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private string cnstr;
        private SqlDataAdapter sda;

        public Funtions()
        {
            cnstr = "Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=carbookingsys_;User ID=carbookingsys_;Password=jiuxib7ysr;";

            conn = new SqlConnection(cnstr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public DataTable GetData(string qry) {
            dt = new DataTable();
            sda =  new SqlDataAdapter(qry,cnstr);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string qry){
            int rcnt = 0;
            if(conn.State == ConnectionState.Closed){
            conn.Open();
            }
            cmd.CommandText = qry;
            rcnt = cmd.ExecuteNonQuery();
            conn.Close();
            return rcnt;
        }
    }
}