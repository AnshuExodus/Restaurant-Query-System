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
    public partial class Welcome : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        //public override object ExecuteScalar();
        public static string fry;
        public Welcome()
        {           
            InitializeComponent();
            try
            {
                label3.Text = HOME.user;                
            }
            catch (NullReferenceException e)
            { }
            //fry = search.Text;
        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        } 
                                
        
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reviews obj = new Reviews();
            obj.Show();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs o = new AboutUs();
            o.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HOME ho = new HOME();
            ho.Show();
            this.Hide();
        }

        private void RN_Click(object sender, EventArgs e)
        {

        }       

        private void WT_Click(object sender, EventArgs e)
        {
            
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile x = new EditProfile();
            this.Hide();
            x.Show();

        }

        private void notificationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security p = new Security();
            this.Hide();
            p.Show();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* connect1();
            OracleCommand cm = new OracleCommand();

            cm.Connection = conn;            
            cm.CommandText = "select * from restaurant natural join location where state=:xy";
            cm.CommandType = CommandType.Text;

            OracleParameter pa1 = new OracleParameter();            
            pa1.ParameterName = "xy";
            pa1.DbType = DbType.String;
            pa1.Value = search.Text;
            fry = search.Text;
            

            cm.Parameters.Add(pa1);
            
            cm.ExecuteNonQuery();*/

            Search p = new Search();
            this.Hide();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("empyreanhaven@gmail.com");
                mail.To.Add("ishsinha@gmail.com");
                mail.Subject = "Cinnamon Password Reset";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("empyreanhaven@gmail.com", "anshumanditi");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Notification oh = new Notification();
            this.Hide();
            oh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ka = new Menu();
            ka.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location no = new Location();
            no.Show();
        }

        private void verificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings o = new Settings();
            this.Hide();
            o.Show();
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            Restaurant o = new Restaurant();
            o.Show();
            this.Hide();
        }

       


    }
}
