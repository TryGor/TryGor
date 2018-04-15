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

namespace TryGor
{
    public partial class Users : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = 2011");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public Users()
        {
            InitializeComponent();
            AutoComplete();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        public void populateDGV()
        {
            // populate the datagridView
            string selectQuery = "SELECT * FROM data.users";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.DataSource = table;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        void AutoComplete()
        {
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string constring = "datasource = localhost; port = 3306; username = root; password = 2011";
            string Query = "Select * from data.users ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("full_name");
                    coll.Add(sName);
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }

            txtSearch.AutoCompleteCustomSource = coll;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("PLEASE ENTER SEARCH TERM!");
                return;
            }
            string searchData = "SELECT * FROM data.users WHERE full_name like '" + txtSearch.Text + "%'";
            command = new MySqlCommand(searchData, connection);
            openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                txtUserID.Text = mdr.GetString("ID").ToString();
                txtFullName.Text = mdr.GetString("full_name");
                txtEmail.Text = mdr.GetString("email");
                txtDOB.Text = mdr.GetString("dateofbirth");
                txtPhone.Text = mdr.GetString("phonenumber");
                txtAddress.Text = mdr.GetString("address");
            }
            else
            {
                MessageBox.Show("USER NOT FOUND IN THE DATABASE");
            }
            closeConnection();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txtDOB.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER FULL NAME!");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER CORRECT EMAIL ADDRESS!");
                return;
            }

            string insertQuery = "INSERT INTO data.users(full_name, email, address, dateofbirth, phonenumber) " +
                "VALUES('" + txtFullName.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtDOB.Text + "','" + txtPhone.Text + "')";
            // executeMyQuery(insertQuery);
            try
            {
                openConnection();
                command = new MySqlCommand(insertQuery, connection);

                adapter = new MySqlDataAdapter(command);

                adapter.InsertCommand = connection.CreateCommand();

                adapter.InsertCommand.CommandText = insertQuery;

                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO ADD NEW USER??", "ADD NEW USER", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("USER SUCCESSFULLY ADDED IN THE SYSTEM!");
                        ClearFields();
                    }
                }
                populateDGV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER FULL NAME!");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER CORRECT EMAIL ADDRESS!");
                return;
            }

            string updateQuery = "UPDATE data.users SET full_name = '" + txtFullName.Text + "', email = '" + txtEmail.Text + "', dateofbirth = '" + txtDOB.Text + "', phonenumber = '" + txtPhone.Text + "', address = '" + txtAddress.Text + "' WHERE ID = " + this.txtUserID.Text + "";
            try
            {
                openConnection();
                command = new MySqlCommand(updateQuery, connection);

                adapter = new MySqlDataAdapter(command);

                adapter.UpdateCommand = connection.CreateCommand();

                adapter.UpdateCommand.CommandText = updateQuery;

                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO CHANGE THIS USER??", "EDIT USER DETAILS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("USER SUCCESSFULLY EDITED!");
                        ClearFields();
                    }
                }
                populateDGV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM data.users where ID = " + this.txtUserID.Text + "";

            try
            {
                openConnection();
                command = new MySqlCommand(deleteQuery, connection);

                adapter = new MySqlDataAdapter(command);

                adapter.DeleteCommand = connection.CreateCommand();

                adapter.DeleteCommand.CommandText = deleteQuery;

                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS USER??", "DELETE USER", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("USER SUCCESSFULLY DELETED FROM THE SYSTEM!");
                        ClearFields();
                    }
                }
                populateDGV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            txtSearch.Text = "";
            txtUserID.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtDOB.Text = "";
            txtPhone.Text = "";
        }

    }
}

