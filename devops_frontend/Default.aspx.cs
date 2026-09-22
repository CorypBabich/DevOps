using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevOps
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] dataLake = getData();

            float[] d4 = { dataLake[0], dataLake[1], dataLake[2], dataLake[3] };
            float[] d6 = { dataLake[4], dataLake[5], dataLake[6], dataLake[7],
                dataLake[8], dataLake[9] };
            float[] d8 = { dataLake[10], dataLake[11], dataLake[12], dataLake[13],
                dataLake[14], dataLake[15], dataLake[16], dataLake[17]};

            int totalD4 = sum(d4);
            int totalD6 = sum(d6);
            int totalD8 = sum(d8);

            lbl_D4_1.Text = "";

            //lblD4tot.Text = totalD4.ToString();
            lbl_D4_1.Text = round(d4[0], totalD4);
            lbl_D4_2.Text = round(d4[1], totalD4);
            lbl_D4_3.Text = round(d4[2], totalD4);
            lbl_D4_4.Text = round(d4[3], totalD4);

            //lblD6tot.Text = totalD6.ToString();
            lbl_D6_1.Text = round(d6[0], totalD6);
            lbl_D6_2.Text = round(d6[1], totalD6);
            lbl_D6_3.Text = round(d6[2], totalD6);
            lbl_D6_4.Text = round(d6[3], totalD6);
            lbl_D6_5.Text = round(d6[4], totalD6);
            lbl_D6_6.Text = round(d6[5], totalD6);

            //lblD8tot.Text = totalD8.ToString();
            lbl_D8_1.Text = round(d8[0], totalD8);
            lbl_D8_2.Text = round(d8[1], totalD8);
            lbl_D8_3.Text = round(d8[2], totalD8);
            lbl_D8_4.Text = round(d8[3], totalD8);
            lbl_D8_5.Text = round(d8[4], totalD8);
            lbl_D8_6.Text = round(d8[5], totalD8);
            lbl_D8_7.Text = round(d8[6], totalD8);
            lbl_D8_8.Text = round(d8[7], totalD8);
        }

        protected void btn1d4Roll_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            //txtLCD.Text += temp.Text;
        }

        protected void btn1d6Roll_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            //txtLCD.Text += temp.Text;
        }
        protected void btn1d8Roll_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            //txtLCD.Text += temp.Text;
        }

        public string round(float num, int total)
        {
            return Math.Round(((num / total) * 100), 0).ToString() + "%"; ;
        }

        public int[] getData()
        {
            Random rnd = new Random();
            int[] outPut = new int[18];
            int max = 30;
            int count = 0;

            for (int i = 0; i < outPut.Length; i++)
            {
                outPut[i] = rnd.Next(1, max);
            }

            return outPut;
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