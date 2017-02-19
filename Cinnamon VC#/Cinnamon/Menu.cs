using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Net.Mail;
using System.Data.OleDb;

namespace Cinnamon
{
    public partial class Menu : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Menu()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        } 



        private void Previous_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            label8.Text = dr["Rest_ID"].ToString();
            label7.Text = dr["Dish_No"].ToString();
            label6.Text = dr["Dish_Name"].ToString();
            label5.Text = dr["Price_Per_Dish"].ToString();
            label4.Text = dr["Serving_Size"].ToString();            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            label8.Text = dr["Rest_ID"].ToString();
            label7.Text = dr["Dish_No"].ToString();
            label6.Text = dr["Dish_Name"].ToString();
            label5.Text = dr["Price_Per_Dish"].ToString();
            label4.Text = dr["Serving_Size"].ToString();    
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "SELECT * from MENU";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "MENU");
            dt = ds.Tables["MENU"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " Present Menu Items.");
            dr = dt.Rows[i];
            label8.Text = dr["Rest_ID"].ToString();
            label7.Text = dr["Dish_No"].ToString();
            label6.Text = dr["Dish_Name"].ToString();
            label5.Text = dr["Price_Per_Dish"].ToString();
            label4.Text = dr["Serving_Size"].ToString();    
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome kp = new Welcome();
            kp.Show();
        }
    }
}
