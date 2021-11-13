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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Close();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            lblUsername.Text = fmrLogin.LogedInAs;
            if(fmrLogin.IsAdmin > 0)
            {
                lblAdminStatus.Text = "TRUE";
            }
            else
            {
                lblAdminStatus.Text = "FALSE";
            }
            
        }

        private void btnUsersMenu_Click(object sender, EventArgs e)
        {
            UsersMenu um = new UsersMenu();
            um.Show();
            this.Hide();
        }
    }
}
