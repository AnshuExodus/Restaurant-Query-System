using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Cinnamon
{
    public partial class Restaurant : Form
    {

        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Restaurant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome p = new Welcome();
            p.Show();
        }

        public void connect1()
        {
            string oradb = "Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void connect_to_review_Click(object sender, EventArgs e)
        {
           /* connect1();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;

            cm.Connection = conn;
            cm.CommandText = "select Rest_Name from Restaurant where Price_For_Two IN (select Price_For_Two from Restaurant where Price_For_Two BETWEEN :A AND :B)";
            cm.CommandType = CommandType.Text;

            OracleParameter pa1 = new OracleParameter();
            OracleParameter pa2 = new OracleParameter();
            pa1.ParameterName = "A";
            pa1.DbType = DbType.String;
            pa1.Value = U.Text;
            pa2.ParameterName = "B";
            pa2.DbType = DbType.String;
            pa2.Value = L.Text;

            cm.Parameters.Add(pa1);
            cm.Parameters.Add(pa2);
            cm.ExecuteNonQuery();   

            ds = new DataSet();
            da = new OracleDataAdapter(cm.CommandText, conn);
            da.Fill(ds, "RESTAURANT");
            dt = ds.Tables["RESTAURANT"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " Present Restaurants.");
            dr = dt.Rows[i];

            U.Text = dr["Rest_ID"].ToString();*/
                 
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {

        }
    }
}
