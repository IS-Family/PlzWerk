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

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["User Name"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(userName, "Missouri") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
        }
    }
}