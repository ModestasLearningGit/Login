using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2NoPictures.DAL
{
    class LoginDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool LoginCheck(UserBLL bll)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM LoginUsers2 WHERE username=@username AND User_password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", bll.Username);
                cmd.Parameters.AddWithValue("@password", bll.Password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if(dt.Rows.Count >0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public int isAdmin(string username)
        {
            int isAdmin = 0;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT IsAdmin FROM LoginUsers2 WHERE Username= '" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    isAdmin = int.Parse(dt.Rows[0]["IsAdmin"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return isAdmin;
        }
    }
}
