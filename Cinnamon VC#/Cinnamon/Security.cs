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


namespace Cinnamon
{
  
    public partial class Security : Form
    {
        public static int val = 0;
        public static string variegate;
        public static string variegatep;
        public Security()
        {
            InitializeComponent();
            try
            {
                variegate = HOME.user;
                variegatep = HOME.passx;
            }
            catch (NullReferenceException e)
            { }
        }

        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (!((EID.Text.Contains('@')) && (EID.Text.EndsWith(".com"))))
            {
                MessageBox.Show("Invalid email-id!");
            }
            else
            {
                val = 1;
            }
            if (val == 1)
            {
                connect1();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;

                // cm.CommandText = "SELECT Password from Users where User_ID=''"+variegate+"'';";
                /* cm.CommandText = "SELECT Password from Users";

                 cm.CommandType = CommandType.Text;
                 // cm.ExecuteNonQuery();

                 string P1, P2, P3;

                 ds = new DataSet();
                 da = new OracleDataAdapter(cm.CommandText, conn);

                 da.Fill(ds, "USERS");
                 dt = ds.Tables["USERS"];

                 dr = dt.Rows[i];
                 int t = dt.Rows.Count;

                 string pa = dr["Password"].ToString();

                 for (; i < t; i++)
                 {
                     switch (i)
                     {
                         case 0: P1 = dr["Password"].ToString(); break;
                         case 1: P2 = dr["Password"].ToString(); break;
                         case 2: P3 = dr["Password"].ToString(); break;
                         default: break;
                     }

                 } */



                if (textBox1.Text == variegatep)
                {
                    // int v = int.Parse(textBox2.Text);            
                    cm.Connection = conn;
                    cm.CommandText = "update users set password=:pk where user_id=:pdn";
                    cm.CommandType = CommandType.Text;

                    OracleParameter pa1 = new OracleParameter();
                    OracleParameter pa2 = new OracleParameter();
                    pa1.ParameterName = "pk";
                    pa1.DbType = DbType.String;
                    pa1.Value = textBox2.Text;
                    pa2.ParameterName = "pdn";
                    pa2.DbType = DbType.String;
                    pa2.Value = variegate;

                    cm.Parameters.Add(pa1);
                    cm.Parameters.Add(pa2);
                    cm.ExecuteNonQuery();


                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        string t_add = EID.Text;
                        mail.From = new MailAddress("empyreanhaven@gmail.com");
                        mail.To.Add(t_add);
                        mail.Subject = "Cinnamon Password Reset: Hello," + variegate;
                        mail.Body = "Your password is: " + textBox2.Text;

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("empyreanhaven@gmail.com", "anshumanditi");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    this.Hide();
                    Welcome m = new Welcome();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Password entered is invalid!");
                    this.Hide();
                    Welcome mq = new Welcome();
                    mq.Show();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome j = new Welcome();
            j.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
