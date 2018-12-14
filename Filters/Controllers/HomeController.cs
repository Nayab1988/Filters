using Filters.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        //[MyError(ExceptionType =typeof(Exception),View ="Error")]
        [MyAuthorize(Roles="admin",Users ="nayab")]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}