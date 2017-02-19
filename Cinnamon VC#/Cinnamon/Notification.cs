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
    public partial class Notification : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Notification()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select Rest_ID, Response from Review where Rating > all(select avg(Rating) from Review)";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "REVIEW");
            dt = ds.Tables["REVIEW"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " restaurants and counting on the charts!");
            dr = dt.Rows[i];
           
            rating.Text = dr["Rest_ID"].ToString();
            revs.Text = dr["Response"].ToString();

            conn.Close();
        }


        private void Previous_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void rating_Click(object sender, EventArgs e)
        {

        }

        private void revs_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            rating.Text = dr["Rest_ID"].ToString();
            revs.Text = dr["Response"].ToString();
        }

        private void Previous_Click_1(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            rating.Text = dr["Rest_ID"].ToString();
            revs.Text = dr["Response"].ToString();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome k = new Welcome();
            k.Show();
        } 


    }
}
