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
    public partial class Location : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Location()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

      /*  private void Previous_Click(object sender, EventArgs e)
        {
           
        } */

      /*  private void Next_Click(object sender, EventArgs e)
        {

        } */

        private void view_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "SELECT * from LOCATION";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "LOCATION");
            dt = ds.Tables["Location"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " Present Locations.");
            dr = dt.Rows[i];
            r_id.Text = dr["Rest_ID"].ToString();
            state.Text = dr["State"].ToString();
            area.Text = dr["Area"].ToString();
            street.Text = dr["Street_No"].ToString();
            shop.Text = dr["Shop_No"].ToString();
            pincode.Text = dr["Pincode"].ToString();
            ph.Text = dr["Ph_No"].ToString();
            conn.Close();
        }

       

        private void Previous_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            r_id.Text = dr["Rest_ID"].ToString();
            state.Text = dr["State"].ToString();
            area.Text = dr["Area"].ToString();
            street.Text = dr["Street_No"].ToString();
            shop.Text = dr["Shop_No"].ToString();
            pincode.Text = dr["Pincode"].ToString();
            ph.Text = dr["Ph_No"].ToString();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            r_id.Text = dr["Rest_ID"].ToString();
            state.Text = dr["State"].ToString();
            area.Text = dr["Area"].ToString();
            street.Text = dr["Street_No"].ToString();
            shop.Text = dr["Shop_No"].ToString();
            pincode.Text = dr["Pincode"].ToString();
            ph.Text = dr["Ph_No"].ToString();
        }

        private void saving_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome ps = new Welcome();
            ps.Show();
        }

        private void r_id_Click(object sender, EventArgs e)
        {

        }

        private void area_Click(object sender, EventArgs e)
        {

        }

        private void ph_Click(object sender, EventArgs e)
        {

        }

        private void state_Click(object sender, EventArgs e)
        {

        }

        private void shop_Click(object sender, EventArgs e)
        {

        }

        private void street_Click(object sender, EventArgs e)
        {

        }

        private void pincode_Click(object sender, EventArgs e)
        {

        }
        


    }

   



}
