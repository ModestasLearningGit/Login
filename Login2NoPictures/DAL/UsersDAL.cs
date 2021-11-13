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
    class UsersDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "SELECT * FROM LoginUsers2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return dt;
        }

        public bool Insert(UserBLL bll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO LoginUsers2(Username, User_password, IsAdmin, Comment) " +
                "VALUES(@Username, @Password, @IsAdmin, @Comment)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", bll.Username);
                cmd.Parameters.AddWithValue("@Password", bll.Password);
                cmd.Parameters.AddWithValue("@IsAdmin", bll.AdminLevel);
                cmd.Parameters.AddWithValue("@Comment", bll.Comment);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows >0)
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

        public bool Update(UserBLL bll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE LoginUsers2 SET Username=@username, User_password=@userpass, IsAdmin=@IsAdmin, Comment=@Comment " +
                "WHERE user_id=@userID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", bll.Username);
                cmd.Parameters.AddWithValue("@userpass", bll.Password);
                cmd.Parameters.AddWithValue("@IsAdmin", bll.AdminLevel);
                cmd.Parameters.AddWithValue("@Comment", bll.Comment);
                cmd.Parameters.AddWithValue("@userID", bll.UserID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //Query excecuted sufesfullly
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
            
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Delete(UserBLL bll)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM LoginUsers2 WHERE user_id=@userID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", bll.UserID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
    }
}
