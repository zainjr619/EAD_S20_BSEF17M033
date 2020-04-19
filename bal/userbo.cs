using dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace bal
{
    public class userbo
    {
        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            return userDao.ValidateUser(pLogin, pPassword);
        }
        public static int UserSave(String name, String login, String password)
        {
            return userDao.UserSave(name, login, password);

        }
        public static int folderDisplay(String name)
        {
            return userDao.folderDisplay(name);
        }
        public static String LoadAllFolders(String Parent)
        {
            return userDao.LoadAllFolders(Parent);
        }

    }
}