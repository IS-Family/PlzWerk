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

        public ActionResult ClientPortal(string FName, string LName)
        {
            ViewBag.FirstName = FName;
            ViewBag.LastName = LName;
            return View();
        }

        public ActionResult ManagementPortal()
        {
            return View();
        }


        public ActionResult NewClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["User Name"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(userName, "Client1") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("ClientPortal", "Home");

            }
            else if (string.Equals(userName, "Employee") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("ManagementPortal", "Home");

            }
            else if (string.Equals(userName, "Client2") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("ManagementPortal", "Home");

            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Register(FormCollection form, bool rememberMe = false)
        {
            String FirstName = form["First Name"].ToString();
            String LastName = form["Last Name"].ToString();


            FormsAuthentication.SetAuthCookie(FirstName, rememberMe);

            return RedirectToAction("Pricing", "Home", new { FName = FirstName, LName = LastName });

        }
    }
}