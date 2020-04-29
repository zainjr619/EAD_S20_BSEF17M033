using bal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44344", headers: "*", methods: "*")]


    public class UserDataController : ApiController
    {
        //[EnableCors(origins: "https://localhost:44344", headers: "*", methods: "*")]

        [HttpPost]
        public String UserSave(AddUserParamHelper User)
        {
            if (User.Login.Trim()==""|| User.name.Trim() == ""|| User.password.Trim() == "")
            { 
                return "Empty fields";
            }
            var result = userbo.UserSave(User.name, User.Login, User.password);
            if (result > 0)
            {
                return "success";
            }

            return "Errorfalse";
        }
        [Authorize]
        [HttpPost]
        public String folderDisplay(AddFolderParamHelper Folder)
        {
            

            if (Folder.name.Trim() == "")
            {
                return "Empty fields";
            }


            var result = userbo.folderDisplay(Folder.name);
            if (result > 0)
            {
                return "success";
            }
            else
            {
                return "Error";
            }

        }
        [Authorize]
        [HttpPost]
        public String LoadAllFolders(GetFolderParamHelper param)
        {
            return userbo.LoadAllFolders(param.Parent);
        }


    }

    public class GetFolderParamHelper
    {
        public string Parent { get; set; }
    }
    public class AddUserParamHelper
    {
        public string Login { get; set; }

        public string name { get; set; }

        public string password { get; set; }
    }
    public class AddFolderParamHelper
    {
        public string name { get; set; }

        public string Parent { get; set; }

    }



















}