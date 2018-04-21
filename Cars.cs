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
using System.IO;
using System.Drawing.Imaging;

namespace TryGor
{
    public partial class Cars : Form
    {
        MySqlDataReader mdr;
        MySqlCommand mysqlcommand;

        public Cars()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = 1977");

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Picture (*.JPG; *.JPEG; *.PNG; *.GIF)|*.JPG; *.JPEG; *.PNG; *.GIF";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        public void FillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM data.cars WHERE CONCAT " +
                "(id, make, model, productionyear, gearbox, carengine, description) LIKE '%" + valueToSearch + "%'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView.RowTemplate.Height = 60;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView.Columns[7];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      
        }

        void AutoComplete()
        {
            txtModSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtModSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string constring = "datasource = localhost; port = 3306; username = root; password = 1977";
            string Query = "Select * from data.cars ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("model");
                    coll.Add(sName);
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }

            txtModSearch.AutoCompleteCustomSource = coll;
        }

        private void dataGridView_MouseClick(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);

            pictureBox.Image = Image.FromStream(ms);

            txtID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtMake.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txtGearbox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txtEngine.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txtDescription.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            Byte[] img = (Byte[])dataGridView.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);

            pictureBox.Image = Image.FromStream(ms);

            txtID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtMake.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txtGearbox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txtEngine.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txtDescription.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            Byte[] img = (Byte[])dataGridView.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);

            pictureBox.Image = Image.FromStream(ms);

            txtID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtMake.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txtGearbox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txtEngine.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txtDescription.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtMake.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER MAKE!");
                return;
            }

            if (txtModel.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER MODEL!");
                return;
            }

            if (pictureBox.Image == null)
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE UPLOAD PICTURE!");
                return;
            }

            if (txtDescription.Text.Length > 2000)
            {
                MessageBox.Show("MAX NUMBER OF CHARACTERS IN DESCRIPTION IS 2000!", "DESCRIPTION ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtYear.Text.Length > 4)
            {
                MessageBox.Show("MAX NUMBER OF CHARACTERS FOR YEAR IS 4!", "YEAR ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO data.cars(make, model, productionyear, gearbox, carengine, description, picture) " +
                "VALUES (@make, @model, @productionyear, @gearbox, @carengine, @description, @picture)", connection);

            //command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text;
            command.Parameters.Add("@make", MySqlDbType.VarChar).Value = txtMake.Text;
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = txtModel.Text;
            command.Parameters.Add("@productionyear", MySqlDbType.VarChar).Value = txtYear.Text;
            command.Parameters.Add("@gearbox", MySqlDbType.VarChar).Value = txtGearbox.Text;
            command.Parameters.Add("@carengine", MySqlDbType.VarChar).Value = txtEngine.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = txtDescription.Text;
            command.Parameters.Add("@picture", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "NEW CAR ADDED IN THE DATABASE!");
            ClearFields();
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("QUERY NOT EXECUTED!");
            }
            connection.Close();
            FillDGV("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMake.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER MAKE!");
                return;
            }

            if (txtModel.Text == "")
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE ENTER MODEL!");
                return;
            }

            if (pictureBox.Image == null)
            {
                MessageBox.Show("FIELDS MARKED WITH * ARE MANDATORY, PLEASE UPLOAD PICTURE!");
                return;
            }

            if (txtDescription.Text.Length > 2000)
            {
                MessageBox.Show("MAX NUMBER OF CHARACTERS IN DESCRIPTION IS 2000!", "DESCRIPTION ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtYear.Text.Length > 4)
            {
                MessageBox.Show("MAX NUMBER OF CHARACTERS FOR YEAR IS 4!", "YEAR ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE data.cars SET make = @make, model = @model, productionyear = @productionyear, carengine = @carengine, description = @description, picture = @picture WHERE id = @id ", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text;
            command.Parameters.Add("@make", MySqlDbType.VarChar).Value = txtMake.Text;
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = txtModel.Text;
            command.Parameters.Add("@productionyear", MySqlDbType.VarChar).Value = txtYear.Text;
            command.Parameters.Add("@gearbox", MySqlDbType.VarChar).Value = txtGearbox.Text;
            command.Parameters.Add("@carengine", MySqlDbType.VarChar).Value = txtEngine.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = txtDescription.Text;
            command.Parameters.Add("@picture", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "CAR SUCCESSFULLY UPDATED!");
            ClearFields();
            FillDGV("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM data.cars WHERE id = @id ", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text;

            if (MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS CAR??", "DELETE CAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                    ExecMyQuery(command, "CAR SUCCESSFULLY DELETED FROM THE DATABASE!");
                    ClearFields();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ClearFields()
        {
            txtSearch.Text = "";
            txtID.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtGearbox.Text = "";
            txtEngine.Text = "";
            txtDescription.Text = "";
            txtYear.Text = "";
            pictureBox.Image = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(txtSearch.Text);
        }

        /*private void txtModSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(txtModSearch.Text);
        }*/
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                if (txtModSearch.Text == "")
                {
                    MessageBox.Show("PLEASE ENTER SEARCH TERM!");
                    return;
                }
                
                {
                    MySqlCommand command = new MySqlCommand ("SELECT * FROM data.cars WHERE model = @model", connection);
                    command.Parameters.Add("@model", MySqlDbType.VarChar).Value = txtModSearch.Text;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count <= 0)
                    {
                        MessageBox.Show("NO DATA FOUND!");
                        ClearFields();
                    }
                    else
                    {

                        txtID.Text = table.Rows[0][0].ToString();
                        txtMake.Text = table.Rows[0][1].ToString();
                        txtModel.Text = table.Rows[0][2].ToString();
                        txtYear.Text = table.Rows[0][3].ToString();
                        txtGearbox.Text = table.Rows[0][4].ToString();
                        txtEngine.Text = table.Rows[0][5].ToString();
                        txtDescription.Text = table.Rows[0][6].ToString();

                        byte[] img = (byte[])table.Rows[0][7];
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox.Image = Image.FromStream(ms);

                        FillDGV("");
                    }
                }

                /*
                string searchData = "SELECT * FROM data.cars WHERE model like '" + txtModSearch.Text + "%'";
                mysqlcommand = new MySqlCommand(searchData, connection);
                connection.Open();
                mdr = mysqlcommand.ExecuteReader();

                MySqlDataAdapter adapter = new MySqlDataAdapter(mysqlcommand);
                /*
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (mdr.Read())
                {
                    txtID.Text = mdr.GetString("ID").ToString();
                    txtMake.Text = mdr.GetString("make");
                    txtModel.Text = mdr.GetString("model");
                    txtYear.Text = mdr.GetString("productionyear");
                    txtGearbox.Text = mdr.GetString("gearbox");
                    txtEngine.Text = mdr.GetString("carengine");
                    txtDescription.Text = mdr.GetString("description");

                   Byte[] img = (Byte[])dataGridView.CurrentRow.Cells[7].Value;
                    MemoryStream ms = new MemoryStream(img);

                    pictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("CAR NOT FOUND IN THE DATABASE");
                }
                connection.Close();*/
            }
        }
    }
}

