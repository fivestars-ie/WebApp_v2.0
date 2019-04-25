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
    public class AggregatesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Aggregates
        public ActionResult Index()
        {
            return View(db.Aggregates.ToList());
        }

        // GET: Aggregates/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aggregate aggregate = db.Aggregates.Find(id);
            if (aggregate == null)
            {
                return HttpNotFound();
            }
            return View(aggregate);
        }

        // GET: Aggregates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aggregates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Suburb_name,Region_name,Unit_type,Year,Job_type,Total_jobs,Total_hospitals,Total_parks,Total_colleges")] Aggregate aggregate)
        {
            if (ModelState.IsValid)
            {
                db.Aggregates.Add(aggregate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aggregate);
        }

        // GET: Aggregates/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aggregate aggregate = db.Aggregates.Find(id);
            if (aggregate == null)
            {
                return HttpNotFound();
            }
            return View(aggregate);
        }

        // POST: Aggregates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Suburb_name,Region_name,Unit_type,Year,Job_type,Total_jobs,Total_hospitals,Total_parks,Total_colleges")] Aggregate aggregate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aggregate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aggregate);
        }

        // GET: Aggregates/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aggregate aggregate = db.Aggregates.Find(id);
            if (aggregate == null)
            {
                return HttpNotFound();
            }
            return View(aggregate);
        }

        // POST: Aggregates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Aggregate aggregate = db.Aggregates.Find(id);
            db.Aggregates.Remove(aggregate);
            db.SaveChanges();
            return RedirectToAction("Index");
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
