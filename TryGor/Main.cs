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
<<<<<<< HEAD
            //this.Hide();
            Services ss = new Services();
            ss.Show();
=======
            this.Hide();
            Users us = new Users();
            us.Show();
>>>>>>> 4d2bcf3e42206fda73109bc753431112bce0f40f
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //this.Hide();
            Reports rp = new Reports();
            rp.Show();
=======
            this.Hide();
            Users us = new Users();
            us.Show();
>>>>>>> 4d2bcf3e42206fda73109bc753431112bce0f40f
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
<<<<<<< HEAD

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
=======
>>>>>>> 4d2bcf3e42206fda73109bc753431112bce0f40f
    }
}
