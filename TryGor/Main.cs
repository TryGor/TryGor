using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryGor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users us = new Users();
            us.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users us = new Users();
            us.Show();
        }

        private void btnPwrUser_Click(object sender, EventArgs e)
        {
            //this.Hide();
            RegForm rf = new RegForm();
            rf.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Users us = new Users();
            us.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn li = new LogIn();
            li.Show();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            /*
            this.IsMdiContainer = true;
            Cars ca = new Cars();
            ca.MdiParent = this;
            ca.Show();*/

             Cars ca = new Cars();
             ca.Show();
        }
    }
}
