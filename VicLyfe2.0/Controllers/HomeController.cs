using System;
using System.Web;
using System.Web.Mvc;
//using System.Web.Script.Serialization;
//using System.Web.Security;
using VicLyfe2._0.Models;

using System.Collections.Generic;
using System.Linq;

namespace VicLyfe2._0.Controllers
{
    public class HomeController : Controller
    {
        //private readonly double COOKIE_EXPIRES = 30;

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
        
        public ActionResult Ballarat()
        {
            ViewBag.Message = "Ballarat.";

            return View();
        }

        public ActionResult BAWBAW()
        {
            ViewBag.Message = "BAWBAW.";

            return View();
        }

        public ActionResult Bendigo()
        {
            ViewBag.Message = "Bendigo.";

            return View();
        }

        public ActionResult Geelong()
        {
            ViewBag.Message = "Geelong.";

            return View();
        }

        public ActionResult MtBuller()
        {
            ViewBag.Message = "MtBuller.";

            return View();
        }

        
    }
}