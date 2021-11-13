using Login2NoPictures.DAL;
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
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        UserBLL BLL = new UserBLL();
        LoginDAL DAL = new LoginDAL();

        public static string LogedInAs;
        public static int IsAdmin;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BLL.Username = txtUsername.Text;
            BLL.Password = txtPassword.Text;

            bool isSuccess = DAL.LoginCheck(BLL);

            if(isSuccess == true)
            {
                MessageBox.Show("LOGED IN SUCCESFULLY");
                LogedInAs = BLL.Username;

                IsAdmin = DAL.isAdmin(LogedInAs);
                home frmhome = new home();
                frmhome.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("LOGiN FAILED");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
