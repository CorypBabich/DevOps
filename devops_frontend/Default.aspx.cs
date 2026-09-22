using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebGrease.Activities;

namespace DevOps
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //CB_GAMING_CP\SQLEXPRESS

            DataSet ds = new DataSet();

            SqlCommand Comm = new SqlCommand();
            String strSQL = "SELECT * FROM [dbo].[DevOps_DiceRoller]";
            //String strSQL = $"INSERT INTO [dbo].[DevOps_DiceRoller] (DieType, DieVal) VALUES('6','2')";

            //Connect with the SQL Server
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Server=CB_GAMING_CP\SQLEXPRESS;Database=DevOps;Trusted_Connection=True;TrustServerCertificate=True;";


            Comm.Connection = Conn;
            Comm.CommandText = strSQL;

            SqlDataAdapter datAdapt = new SqlDataAdapter();
            datAdapt.SelectCommand = Comm;

            Conn.Open();
            datAdapt.Fill(ds, "DieType");
            Conn.Close();

            int[] d4 = { 0, 0, 0, 0, 0 };
            int[] d6 = { 0, 0, 0, 0, 0, 0, 0 };
            int[] d8 = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[i]["DieType"].ToString());
                switch (ds.Tables[0].Rows[i]["DieType"].ToString())
                {
                    
                    case "4":
                        d4[0]++;
                        d4[int.Parse(ds.Tables[0].Rows[i]["DieVal"].ToString())]++;
                        break;
                    case "6":
                        d6[0]++;
                        d6[int.Parse(ds.Tables[0].Rows[i]["DieVal"].ToString())]++;
                        break;
                    case "8":
                        d8[0]++;
                        d8[int.Parse(ds.Tables[0].Rows[i]["DieVal"].ToString())]++;
                        break;
                }
            }

            //lblD4tot.Text = totalD4.ToString();
            lbl_D4_tot.Text = d4[0].ToString();
            lbl_D4_1.Text = round(d4[1], d4[0]);
            lbl_D4_2.Text = round(d4[2], d4[0]);
            lbl_D4_3.Text = round(d4[3], d4[0]);
            lbl_D4_4.Text = round(d4[4], d4[0]);

            //lblD6tot.Text = totalD6.ToString();
            lbl_D6_tot.Text = d6[0].ToString();
            lbl_D6_1.Text = round(d6[1], d6[0]);
            lbl_D6_2.Text = round(d6[2], d6[0]);
            lbl_D6_3.Text = round(d6[3], d6[0]);
            lbl_D6_4.Text = round(d6[4], d6[0]);
            lbl_D6_5.Text = round(d6[5], d6[0]);
            lbl_D6_6.Text = round(d6[6], d6[0]);

            //lblD8tot.Text = totalD8.ToString();
            lbl_D8_tot.Text = d8[0].ToString();
            lbl_D8_1.Text = round(d8[1], d8[0]);
            lbl_D8_2.Text = round(d8[2], d8[0]);
            lbl_D8_3.Text = round(d8[3], d8[0]);
            lbl_D8_4.Text = round(d8[4], d8[0]);
            lbl_D8_5.Text = round(d8[5], d8[0]);
            lbl_D8_6.Text = round(d8[6], d8[0]);
            lbl_D8_7.Text = round(d8[7], d8[0]);
            lbl_D8_8.Text = round(d8[8], d8[0]);
        }

        protected void btn1d4Roll_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            String roll = getRand(4).ToString();
            d4Input.Text = roll;
            sendToSQL("4", roll);
        }

        protected void btn1d6Roll_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            String roll = getRand(6).ToString();
            d6Input.Text = roll;
            sendToSQL("6", roll);
        }
        protected void btn1d8Roll_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            String roll = getRand(8).ToString();
            d8Input.Text = roll;
            sendToSQL("8", roll);
        }

        public void sendToSQL(String type, String val)
        {
            SqlCommand Comm = new SqlCommand();
            String strSQL = $"INSERT INTO [dbo].[DevOps_DiceRoller] (DieType, DieVal) VALUES('{type}','{val}')";

            //Connect with the SQL Server
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Server=CB_GAMING_CP\SQLEXPRESS;Database=DevOps;Trusted_Connection=True;TrustServerCertificate=True;";


            Comm.Connection = Conn;
            Comm.CommandText = strSQL;

            SqlDataAdapter datAdapt = new SqlDataAdapter();
            datAdapt.SelectCommand = Comm;

            try
            {
                Conn.Open();

                int intRecs = Comm.ExecuteNonQuery();
                //lblError.Text = "SUCCESS: Inserted " + intRecs + " record(s)";
                Conn.Close();
                //this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "ERROR:" + ex.Message;
            }
        }

        public string round(float num, int total)
        {
            if (total != 0)
            {
                return Math.Round(((num / total) * 100), 0).ToString() + "%";
            }
            else { return "0"; }
                
        }

        public int getRand(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max+1);
        }


        public int sum(float[] temp)
        {
            int total = 0;
            foreach (int i in temp)
            {
                total += i;
            }
            return total;
        }
    }
}