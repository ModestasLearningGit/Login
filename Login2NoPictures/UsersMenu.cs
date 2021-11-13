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
    public partial class UsersMenu : Form
    {
        UserBLL  BLL  = new UserBLL();
        UsersDAL DAL = new UsersDAL();
        public UsersMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPanel ap = new adminPanel();
            ap.Show();
        }

        private void UsersMenu_Load(object sender, EventArgs e)
        {
            lblUsername.Text = fmrLogin.LogedInAs;
            if (fmrLogin.IsAdmin > 0)
            {
                lblAdminStatus.Text = "TRUE";
            }
            else
            {
                lblAdminStatus.Text = "FALSE";
            }

            DataTable dt = DAL.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            int isAdmin = 0;
            if(int.Parse(cmbIsAdmin.Text) > 0)
            {
                isAdmin = 1;
            }
            else
            {
                isAdmin = 0;
            }
            BLL.Username = txtUserName.Text;
            BLL.Password = txtUserPass.Text;
            BLL.AdminLevel = isAdmin;
            BLL.Comment = txtComment.Text;

            bool isSuccess = DAL.Insert(BLL);

            if(isSuccess == true)
            {
                MessageBox.Show("DATA INSERTED SUCCESFULLY");
                DataTable dt = DAL.Select();
                dgvUsers.DataSource = dt;

                clear();
            }
            else
            {
                MessageBox.Show("DATA FAILED TO ISNERT");
            }
        }
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtUserName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtUserPass.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            cmbIsAdmin.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtComment.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
        }
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            BLL.UserID = int.Parse(txtUserID.Text);
            BLL.Username = txtUserName.Text;
            BLL.Password = txtUserPass.Text;
            BLL.Comment = txtComment.Text;
            BLL.AdminLevel = int.Parse(cmbIsAdmin.Text);

            isSuccess = DAL.Update(BLL);

            if (isSuccess == true)
            {
                MessageBox.Show("DATA UPDATED");
                clear();

                DataTable dt = DAL.Select();
                dgvUsers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("DATA UPDATE FAILED");
            }

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            BLL.UserID = int.Parse(txtUserID.Text);
            BLL.Username = txtUserName.Text;
            if(BLL.Username == fmrLogin.LogedInAs)
            {
                MessageBox.Show("CANT DELETE YOURSELF");
            }
            else
            {
                isSuccess = DAL.Delete(BLL);
            }
            
            if(isSuccess ==  true)
            {
                MessageBox.Show("RECORD DELETED");
                clear();
                dgvUsers.DataSource = DAL.Select();
            }
            else
            {
                MessageBox.Show("RECORD FAILED TO DELETED");
            }

        }

        public void clear()
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtUserPass.Text = "";
            cmbIsAdmin.Text = "";
            txtComment.Text = "";
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
