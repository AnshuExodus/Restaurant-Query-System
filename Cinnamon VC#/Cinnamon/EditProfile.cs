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
    public partial class EditProfile : Form
    {
        public static string U, P;
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public static int val = 0;
        public EditProfile()
        {
            
            InitializeComponent();
            try
            {
                U = HOME.user;
                P = HOME.passx;
            }
            catch (NullReferenceException e)
            { }
        }
        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Contains('1') || textBox1.Text.Contains('2') || textBox1.Text.Contains('3') || textBox1.Text.Contains('4') || textBox1.Text.Contains('5') || textBox1.Text.Contains('6') || textBox1.Text.Contains('7') || textBox1.Text.Contains('8') || textBox1.Text.Contains('9') || textBox1.Text.Contains('0'))
            {
                MessageBox.Show("Enter only alphabets in the Full Name!");

            }
            if (textBox3.Text.Contains('1') || textBox3.Text.Contains('2') || textBox3.Text.Contains('3') || textBox3.Text.Contains('4') || textBox3.Text.Contains('5') || textBox3.Text.Contains('6') || textBox3.Text.Contains('7') || textBox3.Text.Contains('8') || textBox3.Text.Contains('9') || textBox3.Text.Contains('0'))
            {
                MessageBox.Show("Enter only alphabets in City name!");
            }
            if (textBox5.Text.Contains('a') || textBox5.Text.Contains('b') || textBox5.Text.Contains('c') || textBox5.Text.Contains('d') || textBox5.Text.Contains('e') || textBox5.Text.Contains('f') || textBox5.Text.Contains('g') || textBox5.Text.Contains('h') || textBox5.Text.Contains('i') || textBox5.Text.Contains('j') || textBox5.Text.Contains('k') || textBox5.Text.Contains('l') || textBox5.Text.Contains('m') || textBox5.Text.Contains('n') || textBox5.Text.Contains('o') || textBox5.Text.Contains('p') || textBox5.Text.Contains('q') || textBox5.Text.Contains('r') || textBox5.Text.Contains('s') || textBox5.Text.Contains('t') || textBox5.Text.Contains('u') || textBox5.Text.Contains('v') || textBox5.Text.Contains('w') || textBox5.Text.Contains('x') || textBox5.Text.Contains('y') || textBox5.Text.Contains('z') || textBox5.Text.Contains('A') || textBox5.Text.Contains('B') || textBox5.Text.Contains('C') || textBox5.Text.Contains('D') || textBox5.Text.Contains('E') || textBox5.Text.Contains('F') || textBox5.Text.Contains('G') || textBox5.Text.Contains('H') || textBox5.Text.Contains('I') || textBox5.Text.Contains('J') || textBox5.Text.Contains('K') || textBox5.Text.Contains('L') || textBox5.Text.Contains('M') || textBox5.Text.Contains('N') || textBox5.Text.Contains('O') || textBox5.Text.Contains('P') || textBox5.Text.Contains('Q') || textBox5.Text.Contains('R') || textBox5.Text.Contains('S') || textBox5.Text.Contains('T') || textBox5.Text.Contains('U') || textBox5.Text.Contains('V') || textBox5.Text.Contains('W') || textBox5.Text.Contains('X') || textBox5.Text.Contains('Y') || textBox5.Text.Contains('Z'))
            {
                MessageBox.Show("Enter only numbers in the mobile number!");
            }
            if (!((textBox7.Text.Contains('@')) && (textBox7.Text.EndsWith(".com"))))
            {
                MessageBox.Show("Invalid email-id!");
            }
            else
            {
                val = 1;
            }


            string fullname = textBox1.Text;
            string city = textBox3.Text;
            string insta = textBox2.Text;
            string mob = textBox5.Text;
            string email = textBox7.Text;
            if (val == 1)
            {
                connect1();

                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "update users set user_name=:u1, email_id=:u2, user_mobile=:u3, instagram_handle=:u4, user_city=:u5 where user_id=:pdn";
                cm.CommandType = CommandType.Text;



                OracleParameter p1 = new OracleParameter();
                OracleParameter p2 = new OracleParameter();
                OracleParameter p3 = new OracleParameter();
                OracleParameter p4 = new OracleParameter();
                OracleParameter p5 = new OracleParameter();
                OracleParameter p6 = new OracleParameter();



                p1.ParameterName = "u1";
                p1.DbType = DbType.String;
                p1.Value = fullname;

                p2.ParameterName = "u2";
                p2.DbType = DbType.String;
                p2.Value = email;

                p3.ParameterName = "u3";
                p3.DbType = DbType.String;
                p3.Value = mob;

                p4.ParameterName = "u4";
                p4.DbType = DbType.String;
                p4.Value = insta;

                p5.ParameterName = "u5";
                p5.DbType = DbType.String;
                p5.Value = city;

                p6.ParameterName = "pdn";
                p6.DbType = DbType.String;
                p6.Value = U;


                cm.Parameters.Add(p1);
                cm.Parameters.Add(p2);
                cm.Parameters.Add(p3);
                cm.Parameters.Add(p4);
                cm.Parameters.Add(p5);
                cm.Parameters.Add(p6);
                cm.ExecuteNonQuery();

                MessageBox.Show("Succssfully Updated Profile Info!");
                this.Hide();
                Welcome k = new Welcome();
                k.Show();
            }

            //comm = new OracleCommand();
           /* OracleCommand cm = new OracleCommand();

            // da for OracleDataAdapter

            DataTable dt;
            int RowCount;

            cm.Connection = conn;

            // cm.CommandText = "SELECT * from Users WHERE User_ID='"+username.Text+"' and Password='"+password.Text+"';";
            cm.CommandText = "UPDATE TABLE USERS SET USER_NAME='"+fullname+"';";

            cm.CommandType = CommandType.Text;
            // cm.ExecuteNonQuery();


            ds = new DataSet();
            da = new OracleDataAdapter(cm.CommandText, conn);

            da.Fill(ds, "USERS");
            dt = ds.Tables["USERS"];

            dr = dt.Rows[i];
            int t = dt.Rows.Count;

            int cot = 0;


            /*string us = dr["User_ID"].ToString();
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
             * */
            /*if(textBox1.Text.Contains('1')||textBox1.Text.Contains('2')||textBox1.Text.Contains('3')||textBox1.Text.Contains('4')||textBox1.Text.Contains('5')||textBox1.Text.Contains('6')||textBox1.Text.Contains('7')||textBox1.Text.Contains('8')||textBox1.Text.Contains('9')||textBox1.Text.Contains('0'))
            {
                MessageBox.Show("Enter only alphabets in the Full Name!");
            }
            if (textBox3.Text.Contains('1') || textBox3.Text.Contains('2') || textBox3.Text.Contains('3') || textBox3.Text.Contains('4') || textBox3.Text.Contains('5') || textBox3.Text.Contains('6') || textBox3.Text.Contains('7') || textBox3.Text.Contains('8') || textBox3.Text.Contains('9') || textBox3.Text.Contains('0'))
            {
                MessageBox.Show("Enter only alphabets in City name!");
            }
            if(textBox5.Text.Contains('a')||textBox5.Text.Contains('b')||textBox5.Text.Contains('c')||textBox5.Text.Contains('d')||textBox5.Text.Contains('e')||textBox5.Text.Contains('f')||textBox5.Text.Contains('g')||textBox5.Text.Contains('h')||textBox5.Text.Contains('i')||textBox5.Text.Contains('j')||textBox5.Text.Contains('k')||textBox5.Text.Contains('l')||textBox5.Text.Contains('m')||textBox5.Text.Contains('n')||textBox5.Text.Contains('o')||textBox5.Text.Contains('p')||textBox5.Text.Contains('q')||textBox5.Text.Contains('r')||textBox5.Text.Contains('s')||textBox5.Text.Contains('t')||textBox5.Text.Contains('u')||textBox5.Text.Contains('v')||textBox5.Text.Contains('w')||textBox5.Text.Contains('x')||textBox5.Text.Contains('y')||textBox5.Text.Contains('z')||textBox5.Text.Contains('A')||textBox5.Text.Contains('B')||textBox5.Text.Contains('C')||textBox5.Text.Contains('D')||textBox5.Text.Contains('E')||textBox5.Text.Contains('F')||textBox5.Text.Contains('G')||textBox5.Text.Contains('H')||textBox5.Text.Contains('I')||textBox5.Text.Contains('J')||textBox5.Text.Contains('K')||textBox5.Text.Contains('L')||textBox5.Text.Contains('M')||textBox5.Text.Contains('N')||textBox5.Text.Contains('O')||textBox5.Text.Contains('P')||textBox5.Text.Contains('Q')||textBox5.Text.Contains('R')||textBox5.Text.Contains('S')||textBox5.Text.Contains('T')||textBox5.Text.Contains('U')||textBox5.Text.Contains('V')||textBox5.Text.Contains('W')||textBox5.Text.Contains('X')||textBox5.Text.Contains('Y')||textBox5.Text.Contains('Z'))
            {
                MessageBox.Show("Enter only numbers in the mobile number!");
            }
            if(!((textBox7.Text.Contains('@'))&&(textBox7.Text.EndsWith(".com"))))
            {
              MessageBox.Show("Invalid email-id!"); 
            } */
            else
            {
                MessageBox.Show("Correct the information entered");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome u = new Welcome();
            u.Show();
        }
    }
}
