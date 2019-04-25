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
    public class Selected_regionController : Controller
    {
        private Model1 db = new Model1();

        // GET: Selected_region
        public ActionResult Index()
        {
            var selected_region = db.Selected_region.Select(s => s).ToList();
            var region = selected_region.Last();

            ViewBag.region = region.Region_name;
            ViewBag.Message = "You Have selected the above Region. Click to proceed";
            return View();
        }

        

        // GET: Selected_region/Create
        public ActionResult Create()
        {
            ViewBag.Region_name = new SelectList(db.Regions, "Region_name", "Region_name");
            return View();
        }

        // POST: Selected_region/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Region_name")] Selected_region selected_region)
        {
            if (ModelState.IsValid)
            {
                var all = db.Selected_region.Select(s => s);
                db.Selected_region.RemoveRange(all);
                db.SaveChanges();

                db.Selected_region.Add(selected_region);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Region_name = new SelectList(db.Regions, "Region_name", "Region_name", selected_region.Region_name);
            return View(selected_region);
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
