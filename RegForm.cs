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

using AesEnDec;
using System.IO;

namespace TryGor
{
    public partial class RegForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = 1977");
        public RegForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if (textBox_Username.Text.Length < 3 || textBox_Password.Text.Length < 5)
            {
                MessageBox.Show("USERNAME OR PASSWORD IS INVALID OR TOO SHORT, PLEASE TRY AGAIN!");
            }
            else
            {
                string insertQuery = "INSERT INTO data.login(username,password) " +
                "VALUES('" + textBox_Username.Text + "','" + textBox_Password.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("USER SUCCESFULLY ADDED TO DATABASE!");
                    }
                    else
                    {
                        MessageBox.Show("USER NOT ADDED TO DATABASE!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RegForm NewForm = new RegForm();
                NewForm.Show();
                this.Dispose(false);
                connection.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
