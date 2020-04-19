using bal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult login()
        {
            ViewData["CredentialErrors"] = TempData["incorrect"];
            return View();
        }
        [HttpGet]
        public ActionResult Signup()
        {
            ViewData["CredentialErrors"] = TempData["incorrect"];
            return View();
        }

        public ActionResult Home()
        {
              
            if ( Session["user"] != null )
            {
                return View($"Home");
            }
            TempData["incorrect"] = "INVALID";
            return Redirect(url: $"login");
          
        }
        [HttpPost]
        public String ValidateUser(String Login, String password)
        {
            if (String.IsNullOrEmpty(Login) || String.IsNullOrEmpty(password))
            {
                return "Empty fields";
            }


            var result = userbo.ValidateUser(Login, password);
            if (result == true)
            {
                Session["user"] = true;
                return "success";
            }
            else
            {
                ViewData["CredentialErrors"] = "INVALID";
            }

            return "Errorfalse";

        }
        [HttpPost]
        public String UserSave(String name, String Login, String password)
        {

            if (String.IsNullOrEmpty(Login) || String.IsNullOrEmpty(password)||
                String.IsNullOrEmpty(name))
            {
                return "Empty fields";
            }



            var result=userbo.UserSave(name, Login, password);
            if (result>0)
            {
                Session["user"] = true;
                return "success";
            }
            else
            {
                ViewData["CredentialErrors"] = "INVALID";
            }

            return "Errorfalse";
        }
        [HttpPost]
        public String folderDisplay(String name)
        {

            if (String.IsNullOrEmpty(name))
            {
                return "Empty fields";
            }


            var result =userbo.folderDisplay(name);
            if (result > 0)
            {
                Session["user"] = true;
                return "success";
            }
            else
            {
                ViewData["CredentialErrors"] = "INVALID";
            }
            return "Error";
        }
        [HttpPost]
        public  String LoadAllFolders(String Parent)
        {
            return userbo.LoadAllFolders(Parent);
        }










    }
}