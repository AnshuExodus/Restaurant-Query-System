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
    public partial class Sign_Up : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public static int val = 0;

        public Sign_Up()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            string oradb = ";Data Source=localhost;User ID=system;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('1') || textBox1.Text.Contains('2') || textBox1.Text.Contains('3') || textBox1.Text.Contains('4') || textBox1.Text.Contains('5') || textBox1.Text.Contains('6') || textBox1.Text.Contains('7') || textBox1.Text.Contains('8') || textBox1.Text.Contains('9') || textBox1.Text.Contains('0'))
            {
                MessageBox.Show("Enter only alphabets in the Full Name!");

            }
            if (textBox2.Text.Contains('1') || textBox2.Text.Contains('2') || textBox2.Text.Contains('3') || textBox2.Text.Contains('4') || textBox2.Text.Contains('5') || textBox2.Text.Contains('6') || textBox2.Text.Contains('7') || textBox2.Text.Contains('8') || textBox2.Text.Contains('9') || textBox2.Text.Contains('0'))
            {
                MessageBox.Show("Enter only alphabets in City name!");
            }
            if (textBox4.Text.Contains('a') || textBox4.Text.Contains('b') || textBox4.Text.Contains('c') || textBox4.Text.Contains('d') || textBox4.Text.Contains('e') || textBox4.Text.Contains('f') || textBox4.Text.Contains('g') || textBox4.Text.Contains('h') || textBox4.Text.Contains('i') || textBox4.Text.Contains('j') || textBox4.Text.Contains('k') || textBox4.Text.Contains('l') || textBox4.Text.Contains('m') || textBox4.Text.Contains('n') || textBox4.Text.Contains('o') || textBox4.Text.Contains('p') || textBox4.Text.Contains('q') || textBox4.Text.Contains('r') || textBox4.Text.Contains('s') || textBox4.Text.Contains('t') || textBox4.Text.Contains('u') || textBox4.Text.Contains('v') || textBox4.Text.Contains('w') || textBox4.Text.Contains('x') || textBox4.Text.Contains('y') || textBox4.Text.Contains('z') || textBox4.Text.Contains('A') || textBox4.Text.Contains('B') || textBox4.Text.Contains('C') || textBox4.Text.Contains('D') || textBox4.Text.Contains('E') || textBox4.Text.Contains('F') || textBox4.Text.Contains('G') || textBox4.Text.Contains('H') || textBox4.Text.Contains('I') || textBox4.Text.Contains('J') || textBox4.Text.Contains('K') || textBox4.Text.Contains('L') || textBox4.Text.Contains('M') || textBox4.Text.Contains('N') || textBox4.Text.Contains('O') || textBox4.Text.Contains('P') || textBox4.Text.Contains('Q') || textBox4.Text.Contains('R') || textBox4.Text.Contains('S') || textBox4.Text.Contains('T') || textBox4.Text.Contains('U') || textBox4.Text.Contains('V') || textBox4.Text.Contains('W') || textBox4.Text.Contains('X') || textBox4.Text.Contains('Y') || textBox4.Text.Contains('Z'))
            {
                MessageBox.Show("Enter only numbers in the mobile number!");
            }

            if (username.Text.Contains('1') || username.Text.Contains('2') || username.Text.Contains('3') || username.Text.Contains('4') || username.Text.Contains('5') || username.Text.Contains('6') || username.Text.Contains('7') || username.Text.Contains('8') || username.Text.Contains('9') || username.Text.Contains('0'))
            {
                MessageBox.Show("Enter alphabets only for the username!");
            }
            if (!((textBox5.Text.Contains('@')) && (textBox5.Text.EndsWith(".com"))))
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

                cm.CommandText = "insert into USERS (User_ID, User_Name, Password, User_City, Instagram_Handle, Email_ID, User_Mobile) values ('" + username.Text + "', '" + textBox1.Text + "', '" + password.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "')";
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Thanks for signing up," + username.Text + "!");

                this.Hide();

                /*if (textBox1.Text.Contains('1') || textBox1.Text.Contains('2') || textBox1.Text.Contains('3') || textBox1.Text.Contains('4') || textBox1.Text.Contains('5') || textBox1.Text.Contains('6') || textBox1.Text.Contains('7') || textBox1.Text.Contains('8') || textBox1.Text.Contains('9') || textBox1.Text.Contains('0'))
                {
                    MessageBox.Show("Enter only alphabets in the Full Name!");

                }
                if (textBox2.Text.Contains('1') || textBox2.Text.Contains('2') || textBox2.Text.Contains('3') || textBox2.Text.Contains('4') || textBox2.Text.Contains('5') || textBox2.Text.Contains('6') || textBox2.Text.Contains('7') || textBox2.Text.Contains('8') || textBox2.Text.Contains('9') || textBox2.Text.Contains('0'))
                {
                    MessageBox.Show("Enter only alphabets in City name!");
                }
                if (textBox4.Text.Contains('a') || textBox4.Text.Contains('b') || textBox4.Text.Contains('c') || textBox4.Text.Contains('d') || textBox4.Text.Contains('e') || textBox4.Text.Contains('f') || textBox4.Text.Contains('g') || textBox4.Text.Contains('h') || textBox4.Text.Contains('i') || textBox4.Text.Contains('j') || textBox4.Text.Contains('k') || textBox4.Text.Contains('l') || textBox4.Text.Contains('m') || textBox4.Text.Contains('n') || textBox4.Text.Contains('o') || textBox4.Text.Contains('p') || textBox4.Text.Contains('q') || textBox4.Text.Contains('r') || textBox4.Text.Contains('s') || textBox4.Text.Contains('t') || textBox4.Text.Contains('u') || textBox4.Text.Contains('v') || textBox4.Text.Contains('w') || textBox4.Text.Contains('x') || textBox4.Text.Contains('y') || textBox4.Text.Contains('z') || textBox4.Text.Contains('A') || textBox4.Text.Contains('B') || textBox4.Text.Contains('C') || textBox4.Text.Contains('D') || textBox4.Text.Contains('E') || textBox4.Text.Contains('F') || textBox4.Text.Contains('G') || textBox4.Text.Contains('H') || textBox4.Text.Contains('I') || textBox4.Text.Contains('J') || textBox4.Text.Contains('K') || textBox4.Text.Contains('L') || textBox4.Text.Contains('M') || textBox4.Text.Contains('N') || textBox4.Text.Contains('O') || textBox4.Text.Contains('P') || textBox4.Text.Contains('Q') || textBox4.Text.Contains('R') || textBox4.Text.Contains('S') || textBox4.Text.Contains('T') || textBox4.Text.Contains('U') || textBox4.Text.Contains('V') || textBox4.Text.Contains('W') || textBox4.Text.Contains('X') || textBox4.Text.Contains('Y') || textBox4.Text.Contains('Z'))
                {
                    MessageBox.Show("Enter only numbers in the mobile number!");
                }

                if (username.Text.Contains('1') || username.Text.Contains('2') || username.Text.Contains('3') || username.Text.Contains('4') || username.Text.Contains('5') || username.Text.Contains('6') || username.Text.Contains('7') || username.Text.Contains('8') || username.Text.Contains('9') || username.Text.Contains('0'))
                {
                    MessageBox.Show("Enter alphabets only for the username!");
                }
                if (!((textBox5.Text.Contains('@')) && (textBox5.Text.EndsWith(".com"))))
                {
                    MessageBox.Show("Invalid email-id!");
                } */
            }
        }
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
