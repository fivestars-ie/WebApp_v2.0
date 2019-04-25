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
    public class RegionsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Regions
        public ActionResult Index()
        {
            var regions = db.Regions.Include(r => r.Selected_region);
            return View(regions.ToList());
        }

        

        // GET: Regions/Create
        public ActionResult Create()
        {
            ViewBag.Region_name = new SelectList(db.Selected_region, "Region_name", "Region_name");
            return View();
        }

        // POST: Regions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Region_name")] Region region)
        {
            if (ModelState.IsValid)
            {
                db.Regions.Add(region);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Region_name = new SelectList(db.Selected_region, "Region_name", "Region_name", region.Region_name);
            return View(region);
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
