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

namespace Cinnamon
{
    public partial class Reviews : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Reviews()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect1();
            comm= new OracleCommand();
            comm.CommandText = "select * from RESTAURANT";
            comm.CommandType = CommandType.Text;
        }

        public void connect1()
        {
            string oradb = "Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void connect_to_review_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "SELECT * from REVIEW";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "REVIEW");
            dt = ds.Tables["REVIEW"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString()+" Present Reveiews.");
            dr = dt.Rows[i];
            reviewer_id.Text = dr["Reviewer_ID"].ToString();
            rest_id.Text = dr["Rest_ID"].ToString();
            rating.Text = dr["Rating"].ToString();
            std_response.Text = dr["Std_Response"].ToString();
            response.Text = dr["Response"].ToString();
            loc_review.Text = dr["Loc_Review"].ToString();
            conn.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            reviewer_id.Text = dr["Reviewer_ID"].ToString();
            rest_id.Text = dr["Rest_ID"].ToString();
            rating.Text = dr["Rating"].ToString();
            std_response.Text = dr["Std_Response"].ToString();
            response.Text = dr["Response"].ToString();
            loc_review.Text = dr["Loc_Review"].ToString();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            reviewer_id.Text = dr["Reviewer_ID"].ToString();
            rest_id.Text = dr["Rest_ID"].ToString();
            rating.Text = dr["Rating"].ToString();
            std_response.Text = dr["Std_Response"].ToString();
            response.Text = dr["Response"].ToString();
            loc_review.Text = dr["Loc_Review"].ToString();
        }

        private void submit_response_Click(object sender, EventArgs e)
        {
            connect1();

            int r_id = int.Parse(reviewer_id.Text);
            int rate = int.Parse(rating.Text);

            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;                                    
            
            cm.CommandText = "insert into REVIEW (Reviewer_ID, Rest_ID, Rating, Std_Response, Response, Loc_Review) values('" + r_id + "', '" + rest_id.Text + "','" + rate + "','" + std_response.Text + "','" + response.Text + "' , '" + loc_review.Text + "')";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();

            MessageBox.Show("Review Added Successfully!");
            string reviewer = reviewer_id.Text;
            if (reviewer.Contains("1") || reviewer.Contains("2") || reviewer.Contains("3") || reviewer.Contains("4") || reviewer.Contains("5") || reviewer.Contains("6") || reviewer.Contains("7") || reviewer.Contains("8") || reviewer.Contains("9") || reviewer.Contains("0"))
            {
            }
            else
            {
                MessageBox.Show(" Reviewer ID: Enter only numeric values!");
            }
            string rest = rest_id.Text;
            if(rest.Contains("1") || rest.Contains("2") || rest.Contains("3") || rest.Contains("4") || rest.Contains("5") || rest.Contains("6") || rest.Contains("7") || rest.Contains("8") || rest.Contains("9") || rest.Contains("0"))
            {
            }
            else
            {
                MessageBox.Show(" Restaurant_ID : Enter only numeric values!");
            }

           // string email_id = email.Text;

           /* if (email_id.Contains("@") && email_id.Contains(".com"))
            { }
            else
            {
                MessageBox.Show("Enter a valid email address!");
            }*/

            if ((rate < 0) && (rate > 10))
            {
                MessageBox.Show("Enter a value from 0 to 10 only!");
            }
            conn.Close();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome k = new Welcome();
            k.Show();
            this.Hide();
        }

        private void fan_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectToDb()
        {
            try
            {
                connect1();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "avera";
                cm.CommandType = CommandType.StoredProcedure;
                OracleParameter retval = new OracleParameter("myretval", OracleDbType.Int32, 5);
                retval.Direction = ParameterDirection.ReturnValue;
                cm.Parameters.Add(retval);

                cm.Parameters.Add(new OracleParameter(fan.Text, OracleDbType.Int32)).Value = fan.Text;
                cm.ExecuteNonQuery();
                conn.Close();

                string ps = retval.Value.ToString();
                
                    MessageBox.Show("Average rating is "+ps);                                  
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception! Please Enter A Random Integer In The TextBox");
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            conn.Close();
            connect1();            
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;*/

            /*connect1();
            comm = new OracleCommand();
            comm.CommandText = "select aver from av";
            comm.CommandType = CommandType.Text;            
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "AV");
            dt = ds.Tables["AV"];
            int t = dt.Rows.Count;
            dr = dt.Rows[i];
            textBox2.Text = dr["aver"].ToString();
            MessageBox.Show(textBox2.Text);
            conn.Close();*/

            connectToDb();

        }

        

        

       
    }
}
