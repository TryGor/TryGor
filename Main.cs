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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Services ss = new Services();
            ss.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Reports rp = new Reports();
            rp.Show();
        }

        private void btnPwrUser_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            RegForm rf = new RegForm();
            rf.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit GT_ERC?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit GT_ERC?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            //Enviroment.Exit(1);
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

        /*protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }*/
    }
}
