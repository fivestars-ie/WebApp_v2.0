using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VicLyfe2._0.Models;

namespace VicLyfe2._0.Controllers
{
    public class SuburbsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Suburbs
        

        

        // GET: Suburbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suburbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "city")] Suburb suburb)
        {
            suburb.Region = "Region";
            suburb.area = 3555;
            suburb.means = 90;
            Session["Suburb4"] = suburb.city.ToUpper();

            if (db.Suburbs.Count(m => (m.city).ToUpper() == (suburb.city).ToUpper()) == 1 )
            {
                return RedirectToAction("Explore4");
            }
            else
            {
                return RedirectToAction("ExploreError");
            }
        }

        public ActionResult Explore4()
        {
            ViewBag.Suburb4 = Session["Suburb4"];
            return View();
        }

        public ActionResult Explore41()
        {
            ViewBag.Suburb4 = Session["Suburb4"];
            return View();
        }

        public ActionResult Explore42()
        {
            ViewBag.Suburb4 = Session["Suburb4"];
            return View();
        }

        public ActionResult Explore43()
        {
            ViewBag.Suburb4 = Session["Suburb4"];
            return View();
        }

        public ActionResult Explore44()
        {
            ViewBag.Suburb4 = Session["Suburb4"];
            return View();
        }

        public ActionResult Explore45()
        {
            ViewBag.Suburb4 = Session["Suburb4"];
            return View();
        }

        public ActionResult ExploreError()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
