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
    public partial class Search : Form
    {
        OracleConnection conn;
        OracleCommand comm;        
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Search()
        {
            InitializeComponent();

        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        } 

        private void back_Click(object sender, EventArgs e)
        {
            Welcome x = new Welcome();
            this.Hide();
            x.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            /*connect1();
            comm = new OracleCommand();
            comm.CommandText = "SELECT * from RESTAURANT";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "RESTAURANT");
            dt = ds.Tables["RESTAURANT"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " Present Restaurants.");
            dr = dt.Rows[i];
            name.Text = dr["Rest_Name"].ToString();
            id.Text = dr["Rest_ID"].ToString();
            michelin_stars.Text = dr["Michelin_Stars"].ToString();
            price_for_two.Text = dr["Price_For_Two"].ToString();           
            conn.Close();*/
        }

       

      

        private void Go_Click_1(object sender, EventArgs e)
        {



            /*string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
            string firstSql = null;
            string secondSql = null;
            int i = 0;
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Your mdb filename;";
            firstSql = "Your First SQL Statement Here";
            secondSql = "Your Second SQL Statement Here";
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(firstSql, connection);
                oledbAdapter.Fill(ds, "First Table");
                oledbAdapter.SelectCommand.CommandText = secondSql;
                oledbAdapter.Fill(ds, "Second Table");
                oledbAdapter.Dispose();
                connection.Close();
                //retrieve first table data 
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1]);
                }
                //retrieve second table data 
                for (i = 0; i <= ds.Tables[1].Rows.Count - 1; i++)
                {
                    MessageBox.Show(ds.Tables[1].Rows[i].ItemArray[0] + " -- " + ds.Tables[1].Rows[i].ItemArray[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/

            /*OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "xy";
            pa1.DbType = DbType.String;
            pa1.Value = searchbar.Text;           
            
            cm.Parameters.Add(pa1);*/
            // cm.ExecuteQuery();

            /*connect1();
            comm = new OracleCommand();
            comm.CommandText = "SELECT * from REVIEW";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "REVIEW");
            dt = ds.Tables["REVIEW"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " Present Reveiews.");
            dr = dt.Rows[i];
            reviewer_id.Text = dr["Reviewer_ID"].ToString();
            rest_id.Text = dr["Rest_ID"].ToString();
            rating.Text = dr["Rating"].ToString();
            std_response.Text = dr["Std_Response"].ToString();
            response.Text = dr["Response"].ToString();
            loc_review.Text = dr["Loc_Review"].ToString();
            conn.Close();*/

            connect1();
            comm = new OracleCommand();
            comm.CommandText = "SELECT * from RESTAURANT";
            comm.CommandType = CommandType.Text;                       
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "RESTAURANT");            
            dt = ds.Tables["Restaurant"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString() + " Present Restaurants In Area");
            dr = dt.Rows[i];
            name.Text = dr["Rest_Name"].ToString();
            id.Text = dr["Rest_ID"].ToString();
            michelin_stars.Text = dr["Michelin_Stars"].ToString();
            price_for_two.Text = dr["Price_For_Two"].ToString();
            conn.Close(); 
        }

        private void Next_Click(object sender, EventArgs e)
        {
           
        }

        private void previous_Click(object sender, EventArgs e)
        {
            
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void N_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            name.Text = dr["Rest_Name"].ToString();
            id.Text = dr["Rest_ID"].ToString();
            michelin_stars.Text = dr["Michelin_Stars"].ToString();
            price_for_two.Text = dr["Price_For_Two"].ToString();
        }

        private void P_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            name.Text = dr["Rest_Name"].ToString();
            id.Text = dr["Rest_ID"].ToString();
            michelin_stars.Text = dr["Michelin_Stars"].ToString();
            price_for_two.Text = dr["Price_For_Two"].ToString();
        }
    }


}
