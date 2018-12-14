using Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User usr, string ReturnUrl)
        {
            if (IsValid(usr))
            {
                FormsAuthentication.SetAuthCookie(usr.UserName, true);
                return Redirect(ReturnUrl);
            }
            else
            {
                return View(usr);
            }
        }
        private bool IsValid(User usr)
        {
            if (usr.UserName == "nayab" && usr.password == "123")
                return true;
            else
                return false;

        }
    }
    
}