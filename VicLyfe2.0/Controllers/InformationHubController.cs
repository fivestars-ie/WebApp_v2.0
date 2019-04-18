using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VicLyfe2._0.Controllers
{
    public class InformationHubController : Controller
    {
        public ActionResult InformationHub()
        {
            ViewBag.Message = "InformationHub";
            return View();
        }
        public ActionResult ViewPage1()
        {
            ViewBag.Message = "View comparison of Metropolitan and Regional Areas";

            return View();
        }

        public ActionResult ViewPage2()
        {
            ViewBag.Message = "Comparison of different Regional Areas in Victoria in terms of Crime, Jobs and Rent";

            return View();
        }

        public ActionResult ViewPage3()
        {
            ViewBag.Message = "Select and view data about your City!";

            return View();
        }


    }
}