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

namespace example
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Click on Close button should close the complete application.
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the Application?", "Exit", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
                //e.Cancel = true;
                Application.Exit();
        }
        //Connecting to the database through the connection string
        public void connect1()
        {
            string oradb = "Data Source=SUSHANTBHAT;User ID=system;Password=mamatabhat";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        

        

        




 

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from instructor";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "instructor");
            dt = ds.Tables["instructor"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox1.Text = dr["id"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["deptname"].ToString();
            textBox4.Text = dr["salary"].ToString();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["id"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["deptname"].ToString();
            textBox4.Text = dr["salary"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox1.Text = dr["id"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["deptname"].ToString();
            textBox4.Text = dr["salary"].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect1();
            int sal = int.Parse(textBox4.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into instructor values(’" + textBox1.Text + "’,’" + textBox2.Text + "’,’" + textBox3.Text + "’,’" + textBox4.Text + "’)";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted!");
            conn.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            connect1();
            int v = int.Parse(textBox4.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update instructor set salary=:pb where deptname =:pdn";
            cm.CommandType = CommandType.Text;
            //Uses OracleParameter to read the parameter from the GUI
            OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "pb";
            pa1.DbType = DbType.Int32;
            pa1.Value = v;
            OracleParameter pa2 = new OracleParameter();
            pa2.ParameterName = "pdn";
            pa2.DbType = DbType.String;
            pa2.Value = textBox1.Text;
            cm.Parameters.Add(pa1);
            cm.Parameters.Add(pa2);
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            conn.Close();
        }


    }
}
