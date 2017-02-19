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
    public partial class HOME : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public static string user;
        public static string passx;
        public HOME()
        {
            InitializeComponent();             
        }
        
        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        public void TuckIn_Click(object sender, EventArgs e)
        {
            //try
            {

                user = username.Text;
                string pass = password.Text;
                passx = password.Text;

                int num;
                char f;

                connect1();

                //comm = new OracleCommand();
                OracleCommand cm = new OracleCommand();

                // da for OracleDataAdapter

                DataTable dt;
                int RowCount;

                cm.Connection = conn;

                // cm.CommandText = "SELECT * from Users WHERE User_ID='"+username.Text+"' and Password='"+password.Text+"';";
                cm.CommandText = "SELECT * from Users;";

                cm.CommandType = CommandType.Text;
                // cm.ExecuteNonQuery();


                ds = new DataSet();
                da = new OracleDataAdapter(cm.CommandText, conn);

                da.Fill(ds, "USERS");
                dt = ds.Tables["USERS"];

                dr = dt.Rows[i];
                int t = dt.Rows.Count;

                int cot = 0;


               string us = dr["User_ID"].ToString();
                string pa = dr["Password"].ToString();

                for (; i < t; i++)
                {
                    dr = dt.Rows[i];
                    us = dr["User_ID"].ToString();
                    pa = dr["Password"].ToString();
                    if (username.Text == us)
                    {
                        if (password.Text == pa)
                        {
                            Welcome n = new Welcome();
                            
                            n.Show();
                            this.Hide();
                            cot = 1;
                            break;
                        }
                        
                        
                    }
                   

                }
                if (cot == 0)
                {
                    MessageBox.Show("Invalid Credentials!");
                    i = 0;
                }
                    
               /* if (cot == 1)
                {
                    if (password.Text == pa)
                    {
                        Welcome n = new Welcome();
                        this.Hide();
                        n.Show();
                    }
                }*/
                /*else
                {
                    MessageBox.Show("Invalid Credentials!");
                }
                */



                



                /*if ((username.Text==us) && (password.Text==pa))
                {
                    Welcome n = new Welcome();
                    this.Hide();
                    n.Show();
                }

                else
                {
                    MessageBox.Show("Invalid Credentials!");
                }

            }

           // catch (Exception s) { MessageBox.Show("Error"); }

        



           /* if((user == "Isha") && (pass == "1234"))
            {
                 Welcome x = new Welcome();
                x.Show();
                this.Hide();
            }
            else if((user == "") && (pass == ""))
            {
                MessageBox.Show("Please Enter Username And Password!");
            }

            else if ((user == ""))
            {
                MessageBox.Show("Please Enter Username!");
            }

            else if ((pass == ""))
            {
                MessageBox.Show("Please Enter Password!");
            }



            else
            {
                MessageBox.Show("Invalid Credentials!");
            }*/

                if (username.Text.Contains('1') || username.Text.Contains('2') || username.Text.Contains('3') || username.Text.Contains('4') || username.Text.Contains('5') || username.Text.Contains('6') || username.Text.Contains('7') || username.Text.Contains('8') || username.Text.Contains('9') || username.Text.Contains('0'))
                {
                    MessageBox.Show("Enter alphabets only for the username!");
                }
                
            }
        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up ob = new Sign_Up();
            ob.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
