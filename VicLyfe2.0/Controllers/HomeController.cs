using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using VicLyfe2._0.Models;

namespace VicLyfe2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly double COOKIE_EXPIRES = 30;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Compare()
        {
            return View();
        }

        public ActionResult PRPath()
        {
            ViewBag.Message = "Your PR Suggestions.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult InformationHub()
        {
            ViewBag.Message = "InformationHub.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.UserName.Equals("admin") && model.Password.Equals("123456"))
            {
                string userData = new JavaScriptSerializer().Serialize(model);
                var ticket = new FormsAuthenticationTicket(1, model.UserName, DateTime.Now, DateTime.Now.AddDays(COOKIE_EXPIRES), false, userData, FormsAuthentication.FormsCookiePath);
                string encrypt = FormsAuthentication.Encrypt(ticket);
                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypt);

                Response.Cookies.Remove(cookie.Name);
                Response.Cookies.Add(cookie);

                if (string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                    return Redirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Invalid Login");
                return View(model);
            }
        }
    }
}