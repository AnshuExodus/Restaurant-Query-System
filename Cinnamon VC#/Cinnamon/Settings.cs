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
    public partial class Settings : Form
    {

        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Settings()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void connectToDb()
        {
             try
             {
                 connect1();
                 OracleCommand cm = new OracleCommand();
                 cm.Connection = conn;
                 cm.CommandText = "pass_ver";
                 cm.CommandType = CommandType.StoredProcedure;
                 OracleParameter retval = new OracleParameter("myretval", OracleDbType.Varchar2, 50);
                 retval.Direction = ParameterDirection.ReturnValue;
                 cm.Parameters.Add(retval);

                 cm.Parameters.Add(new OracleParameter(textBox1.Text, OracleDbType.Varchar2)).Value = textBox1.Text;
                 cm.ExecuteNonQuery();
                 conn.Close();
                 string ps = retval.Value.ToString();
                 string pas;
                 pas = textBox2.Text;

                 if (ps == pas)
                 {
                     MessageBox.Show("Password is correct!");
                     this.Hide();
                 }

                 else
                 {
                     MessageBox.Show("Password is incorrect!");
                     this.Hide();
                        
                 }

             }
             catch (Exception e)
             {
                 MessageBox.Show("Exception!");
                 this.Hide();
             }

             this.Hide();
             Welcome k = new Welcome();
             k.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* try
             {
                 connect1();
                 OracleCommand cm = new OracleCommand();
                 cm.Connection = conn;
                 cm.CommandText = "pass_ver";
                 cm.CommandType = CommandType.StoredProcedure;
                 OracleParameter retval = new OracleParameter("myretval", OracleDbType.Varchar2, 50);
                 retval.Direction = ParameterDirection.ReturnValue;
                 cm.Parameters.Add(retval);

                 cm.Parameters.Add(new OracleParameter(textBox1.Text, OracleDbType.Varchar2)).Value = textBox1.Text;
                 cm.ExecuteNonQuery();
                 conn.Close();
                 string ps = retval.Value.ToString();
                 string pas;
                 pas = textBox2.Text;
                 if (ps == pas)
                 {
                     MessageBox.Show("Validated!");
                 }

                 else
                 {
                     MessageBox.Show("Invalid!");
                 }

             }
             catch (Exception e)
             {
                 MessageBox.Show("Exception!");
             }
         }*/

            connectToDb();

        }

    }

}
