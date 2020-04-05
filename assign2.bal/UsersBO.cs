using assign2.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2.bal
{
    public static class UsersBO
    {
        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            return UsersDao.ValidateUser(pLogin, pPassword);
        }
        public static int UserSave(String name, String login, String password, String email, char gender,
           String address, int age, String nic, string dob, bool isCricket, bool hockey, bool football,String uniqueName)
        {
            return UsersDao.UserSave(name, login, password, email, gender,
             address, age, nic, dob, isCricket, hockey, football, uniqueName);

        }
        public static string loadData(String login)
        {
            return UsersDao.loadData(login);

        }
        public static Boolean ValidateAdmin(String pLogin, String pPassword)
        {
            return UsersDao.ValidateAdmin(pLogin, pPassword);
        }
        public static DataTable LoadAllUsers()
        {
            return UsersDao.LoadAllUsers();
        }
        public static string GetEmail(String login)
        {
            return UsersDao.GetEmail(login);

        }
        public static int UpdatePassword(String password, String email)
        {
            return UsersDao.UpdatePassword(password, email);

        }


    }
}
