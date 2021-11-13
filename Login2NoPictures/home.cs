using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2NoPictures
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {
            lblUsername.Text = fmrLogin.LogedInAs;
            if(fmrLogin.IsAdmin >  0)
            {
                lblAdminStatus.Text = "TRUE";
            }
            else
            {
                lblAdminStatus.Text = "FALSE";
                btnAdminPanel.Enabled = false;
            }
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            
            adminPanel ap = new adminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
