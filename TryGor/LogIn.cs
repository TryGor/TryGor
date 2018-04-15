using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using AesEnDec;
using System.IO;


namespace TryGor
{
    public partial class LogIn : Form
    {
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        MySqlConnection myConn = new MySqlConnection(@"Data Source = localhost; port = 3306; Initial Catalog = data; User Id = root; password = 2011");
        
        int i;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) textBox_Password.UseSystemPasswordChar = true;

            else textBox_Password.UseSystemPasswordChar = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            i = 0;
            myConn.Open();
            MySqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from login WHERE BINARY username = '" + textBox_Username.Text + "' and BINARY password = '" + textBox_Password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD, PLEASE TRY AGAIN");
                textBox_Username.Text = "";
                textBox_Password.Text = "";
            }
            else
            {
                timer.Enabled = true;
            }
            myConn.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);

            if (progressBar.Value == 70)
            {
                timer.Stop();
                timer.Enabled = false;
                this.Hide();
                Main mn = new Main();
                mn.Show();
            }
        }
    }
}

