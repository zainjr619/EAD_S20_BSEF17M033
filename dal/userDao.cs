using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dal
{
    public class userDao
    {
        private static String connString = @"Data Source=localhost\SQLEXPRESS2012;Initial Catalog=Assignment4; User Id=sa;Password=neymar11";
        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            
            
           using (SqlConnection conn = new SqlConnection(connString))
           {
              conn.Open();

              String query = String.Format("select count(*) from dbo.User1 where login='{0}'and password='{1}'", pLogin, pPassword);
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

            
        
        public static int UserSave(String name, String login, String password)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                String query = String.Format(@"insert into dbo.User1(Name,Login,Password)" +
                    " select '{0}','{1}','{2}'" +
                    "where(select Login from dbo.User1 where Login='{1}' or Name ='{0}') is null", name, login, password);
                SqlCommand command = new SqlCommand(query, conn);
                var result = command.ExecuteNonQuery();
                //int result = int.Parse(obj);
                return result;
            }
        }
        public static int folderDisplay(String name)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                String query = String.Format(@"insert into dbo.folder(FolderName,ParentFolderID)" +
                   " select '{0}','0'", name);

                SqlCommand command = new SqlCommand(query, conn);
                var result = command.ExecuteNonQuery();                //int result = int.Parse(obj);
                return result;
            }
        }
        public static String LoadAllFolders(String Parent)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                String query =String.Format(@"select FolderID,FolderName from dbo.folder where ParentFolderId = '0'",Parent);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                string result = "";
                if(reader.Read())
                {
                    result += "[[" + reader.GetInt32(0) + ",";
                    result += "\"" + reader.GetString(1) + "\"]";
                    while(reader.Read())
                    {
                        result += ",[" + reader.GetInt32(0) + ",";
                        result+="\"" + reader.GetString(1) + "\"]"; 
                 
                    }
                    result += "]";
                }
                if(result!="")
                {
                    return result;
                }
                return "ERROR";


            }



        }
    }
}

