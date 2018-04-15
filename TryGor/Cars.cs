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
        public Cars()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = 2011");

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
            FillDGV();
        }

        public void FillDGV()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM data.cars", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridView.RowTemplate.Height = 60;
            dataGridView.AllowUserToAddRows = false;
            /*dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToOrderColumns = false;*/
            dataGridView.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView.Columns[7];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
                 
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);

            pictureBox.Image = Image.FromStream(ms);
        }

    }
}
