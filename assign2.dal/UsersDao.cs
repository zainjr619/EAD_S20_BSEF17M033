using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2.dal
{
    public static class UsersDao
    {
        private static String connString = @"Data Source=localhost\SQLEXPRESS2012;Initial Catalog=Assignment4; User Id=sa;Password=neymar11";
        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    String query = String.Format("select count(*) from dbo.Users where login='{0}'and password='{1}'", pLogin, pPassword);
                    SqlCommand command = new SqlCommand(query, conn);
                    var result = (int)command.ExecuteScalar();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            catch (Exception ex)
            {
                return false;

            }
        }
        public static int UserSave(String name, String login, String password, String email, char gender,
            String address, int age, String nic, string dob, bool isCricket, bool hockey, bool football,String uniqueName)
        {
                       
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    String query = String.Format(@"insert into dbo.Users(Name,Login,Password,Email,Gender,Address," +
                        "Age,NIC,DOB,IsCricket,Hockey,Football,ImageName,CreatedOn)" +
                        " select '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}'," +
                        "'{10}','{11}','{12}',GETDATE() " +
                        "where(select Login from dbo.Users where login='{1}' or email ='{3}') is null", name, login, password, email, gender, address, age, nic, dob, isCricket, hockey, football, uniqueName);
                    SqlCommand command = new SqlCommand(query, conn);
                    var result = command.ExecuteNonQuery();
                    //int result = int.Parse(obj);
                    return result;
                }
        }
        public static string loadData(String login)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = String.Format("select * from dbo.Users Where Login='{0}'", login);
                SqlCommand command = new SqlCommand(query, conn);
                var result = command.ExecuteReader();
                String ImageName=null;
                if (result.Read())
                {
                     ImageName =(String)result.GetString(13);
                }
                return ImageName;

            }

        }




    }
}
