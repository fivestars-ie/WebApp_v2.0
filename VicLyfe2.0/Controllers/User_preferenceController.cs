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
    public class User_preferenceController : Controller
    {
        private Model1 db = new Model1();

        // GET: User_preference

        public ActionResult Report()
        {
            ViewBag.SuburbA = Session["Suburb1"];
            ViewBag.SuburbB = Session["Suburb2"];
            ViewBag.SuburbC = Session["Suburb3"];
            ViewBag.Job_field_A = Session["Job1"];
            ViewBag.Job_field_B = Session["Job2"];
            return View();
        }
         
        public ActionResult Explor1()
        {
            return View();
        }

            public ActionResult Explor2()
        {
            return View();
        }

        public ActionResult Explor3()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Suburb1 = Session["Suburb1"];
            ViewBag.Suburb2 = Session["Suburb2"];
            ViewBag.Suburb3 = Session["Suburb3"];
            return View();
        }

        // GET: User_preference/Create
        public ActionResult Create()
        {
            ViewBag.Job_field_1 = new SelectList(db.Job_type, "Job_field", "Job_field");
            ViewBag.Job_field_2 = new SelectList(db.Job_type, "Job_field", "Job_field");
            ViewBag.Do_you_prefer_Parks_and_Reserves = new SelectList(db.Preference_Rating, "Rating", "Rating");
            ViewBag.Educational_Institutes_Requirement = new SelectList(db.Preference_Rating, "Rating", "Rating");
            ViewBag.Hospital_Service_Requirement = new SelectList(db.Preference_Rating, "Rating", "Rating");
            ViewBag.Job_Requirement = new SelectList(db.Preference_Rating, "Rating", "Rating");
            ViewBag.Number_of_bedrooms = new SelectList(db.Unit_type, "Number_of_bedrooms", "Number_of_bedrooms");
            return View();
        }

        // POST: User_preference/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expected_Weekly_Rent,Number_of_bedrooms,Job_field_1,Job_field_2,Job_Requirement,Hospital_Service_Requirement,Do_you_prefer_Parks_and_Reserves,Educational_Institutes_Requirement")] User_preference user_preference)
        {
            user_preference.User_input_time = DateTime.Now;
            var selected_region = db.Selected_region.Select(s => s).ToList();
            var region = selected_region.Last();

            var aggregates = from s in db.Aggregates
                             select s;
            aggregates = aggregates.Where(s => s.Year == 2018);
            aggregates = aggregates.Where(s => s.Region_name.Equals(region.Region_name));
            if (ModelState.IsValid)
            {
                switch (user_preference.Number_of_bedrooms)
                {
                    case "1-Bedroom house":
                        aggregates = aggregates.Where(s => s.Unit_type == 1);
                        break;

                    case "2-Bedroom house":
                        aggregates = aggregates.Where(s => s.Unit_type == 2);
                        break;

                    case "3-Bedroom house":
                        aggregates = aggregates.Where(s => s.Unit_type == 3);
                        break;

                    case "1 and 2 Bedroom house":
                        aggregates = aggregates.Where(s => s.Unit_type == 1 || s.Unit_type == 2);
                        break;

                    case "2 and 3 Bedroom house":
                        aggregates = aggregates.Where(s => s.Unit_type == 2 || s.Unit_type == 3);
                        break;
                }

                aggregates = aggregates.Where(s => s.Job_type.Equals(user_preference.Job_field_1) || s.Job_type.Equals(user_preference.Job_field_2));


                switch (user_preference.Job_Requirement)
                {
                    case "High":
                        aggregates = aggregates.OrderByDescending(s => s.Total_jobs);
                        break;

                    case "Low":
                        aggregates = aggregates.OrderBy(s => s.Total_jobs);
                        break;
                }

                switch (user_preference.Educational_Institutes_Requirement)
                {
                    case "High":
                        aggregates = aggregates.OrderByDescending(s => s.Total_colleges);
                        break;

                    case "Low":
                        aggregates = aggregates.OrderBy(s => s.Total_colleges);
                        break;
                }

                switch (user_preference.Hospital_Service_Requirement)
                {
                    case "High":
                        aggregates = aggregates.OrderByDescending(s => s.Total_hospitals);
                        break;

                    case "Low":
                        aggregates = aggregates.OrderBy(s => s.Total_hospitals);
                        break;
                }

                switch (user_preference.Do_you_prefer_Parks_and_Reserves)
                {
                    case "High":
                        aggregates = aggregates.OrderByDescending(s => s.Total_parks);
                        break;

                    case "Low":
                        aggregates = aggregates.OrderBy(s => s.Total_parks);
                        break;
                }

                List<String> suburbs = aggregates.Select(s => s.Suburb_name).Distinct().Take(3).ToList();
                Session["Suburb1"] = suburbs[0];
                Session["Suburb2"] = suburbs[1];
                Session["Suburb3"] = suburbs[2];
                Session["Job1"] = user_preference.Job_field_1;
                Session["Job2"] = user_preference.Job_field_2;
                return RedirectToAction("Index");
            }

            ViewBag.Job_field_1 = new SelectList(db.Job_type, "Job_field", "Job_field", user_preference.Job_field_1);
            ViewBag.Job_field_2 = new SelectList(db.Job_type, "Job_field", "Job_field", user_preference.Job_field_2);
            ViewBag.Do_you_prefer_Parks_and_Reserves = new SelectList(db.Preference_Rating, "Rating", "Rating", user_preference.Do_you_prefer_Parks_and_Reserves);
            ViewBag.Educational_Institutes_Requirement = new SelectList(db.Preference_Rating, "Rating", "Rating", user_preference.Educational_Institutes_Requirement);
            ViewBag.Hospital_Service_Requirement = new SelectList(db.Preference_Rating, "Rating", "Rating", user_preference.Hospital_Service_Requirement);
            ViewBag.Job_Requirement = new SelectList(db.Preference_Rating, "Rating", "Rating", user_preference.Job_Requirement);
            ViewBag.Number_of_bedrooms = new SelectList(db.Unit_type, "Number_of_bedrooms", "Number_of_bedrooms", user_preference.Number_of_bedrooms);
            return View(user_preference);
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