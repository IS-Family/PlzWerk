using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PlzWerk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pricing()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult ClientPortal()
        {
            return View();
        }

        public ActionResult ManagementPortal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["User Name"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(userName, "Client") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("ClientPortal", "Home");

            }
            else if (string.Equals(userName, "Employee") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("ManagementPortal", "Home");

            }
            else
            {
                return View();
            }
        }
    }
}