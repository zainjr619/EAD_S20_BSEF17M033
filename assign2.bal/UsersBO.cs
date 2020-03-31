using assign2.dal;
using System;
using System.Collections.Generic;
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

    }
}
