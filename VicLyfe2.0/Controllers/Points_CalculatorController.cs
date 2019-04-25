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
    public class Points_CalculatorController : Controller
    {
        private Model1 db = new Model1();

        // GET: Points_Calculator
        public ActionResult Index()
        {
            var points_Calculator = db.Points_Calculator.Include(p => p.Age).Include(p => p.Australian_experience).Include(p => p.Australian_study).Include(p => p.Designated_Language).Include(p => p.Doctrate).Include(p => p.Language_skills).Include(p => p.Overseas_experience).Include(p => p.Partner_level).Include(p => p.Qualification_skills);
            return View(points_Calculator.ToList());
        }

        

        // GET: Points_Calculator/Create
        public ActionResult Create()
        {
            ViewBag.Age_group = new SelectList(db.Ages, "Age_group", "Age_group");
            ViewBag.Australian_work_experience = new SelectList(db.Australian_experience, "Australian_work_experience", "Australian_work_experience");
            ViewBag.Australian_study_requirement = new SelectList(db.Australian_study, "Australian_study_requirement", "Australian_study_requirement");
            ViewBag.Designated_language_skills = new SelectList(db.Designated_Language, "Designated_Language_Service", "Designated_Language_Service");
            ViewBag.Doctrate_or_Master_by_research = new SelectList(db.Doctrates, "Doctrate_or_research_qualification", "Doctrate_or_research_qualification");
            ViewBag.Language_proficiency = new SelectList(db.Language_skills, "Language_proficiency", "Language_proficiency");
            ViewBag.Overseas_work_experience = new SelectList(db.Overseas_experience, "Overseas_work_experience", "Overseas_work_experience");
            ViewBag.Partner_skills = new SelectList(db.Partner_level, "Partner_skills", "Partner_skills");
            ViewBag.Qualification = new SelectList(db.Qualification_skills, "Qualification", "Qualification");
            return View();
        }

        // POST: Points_Calculator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Age_group,Language_proficiency,Australian_study_requirement,Qualification,Doctrate_or_Master_by_research,Overseas_work_experience,Australian_work_experience,Partner_skills,Designated_language_skills")] Points_Calculator points_Calculator)
        {
            points_Calculator.Query_date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var points = 0;

                var age_points = from m in db.Ages
                                 where m.Age_group.Equals(points_Calculator.Age_group)
                                 select m.Age_points;
                points = points + age_points.First();

                var language_points = from m in db.Language_skills
                                 where m.Language_proficiency.Equals(points_Calculator.Language_proficiency)
                                 select m.Language_points;
                points = points + language_points.First();

                var AusStudy_points = from m in db.Australian_study
                                 where m.Australian_study_requirement.Equals(points_Calculator.Australian_study_requirement)
                                 select m.Aus_study_points;
                points = points + AusStudy_points.First();

                var Qua_points = from m in db.Qualification_skills
                                 where m.Qualification.Equals(points_Calculator.Qualification)
                                 select m.Qualification_points;
                points = points + Qua_points.First();

                var Doc_points = from m in db.Doctrates
                                 where m.Doctrate_or_research_qualification.Equals(points_Calculator.Doctrate_or_Master_by_research)
                                 select m.Doctrate_points;
                points = points + Doc_points.First();

                var Over_points = from m in db.Overseas_experience
                                 where m.Overseas_work_experience.Equals(points_Calculator.Overseas_work_experience)
                                 select m.OWE_points;
                points = points + Over_points.First();

                var AWE_points = from m in db.Australian_experience
                                 where m.Australian_work_experience.Equals(points_Calculator.Australian_work_experience)
                                 select m.AWE_points;
                points = points + AWE_points.First();

                var part_points = from m in db.Partner_level
                                 where m.Partner_skills.Equals(points_Calculator.Partner_skills)
                                 select m.Partner_points;
                points = points + part_points.First();

                var Des_points = from m in db.Designated_Language
                                 where m.Designated_Language_Service.Equals(points_Calculator.Designated_language_skills)
                                 select m.DLS_points;
                points = points + Des_points.First();

                Session["points"] = points;
                if (points >= 80)
                {
                    return RedirectToAction("Above80");
                }
                else
                {
                    return RedirectToAction("Below80");
                }
            }

            ViewBag.Age_group = new SelectList(db.Ages, "Age_group", "Age_group", points_Calculator.Age_group);
            ViewBag.Australian_work_experience = new SelectList(db.Australian_experience, "Australian_work_experience", "Australian_work_experience", points_Calculator.Australian_work_experience);
            ViewBag.Australian_study_requirement = new SelectList(db.Australian_study, "Australian_study_requirement", "Australian_study_requirement", points_Calculator.Australian_study_requirement);
            ViewBag.Designated_language_skills = new SelectList(db.Designated_Language, "Designated_Language_Service", "Designated_Language_Service", points_Calculator.Designated_language_skills);
            ViewBag.Doctrate_or_Master_by_research = new SelectList(db.Doctrates, "Doctrate_or_research_qualification", "Doctrate_or_research_qualification", points_Calculator.Doctrate_or_Master_by_research);
            ViewBag.Language_proficiency = new SelectList(db.Language_skills, "Language_proficiency", "Language_proficiency", points_Calculator.Language_proficiency);
            ViewBag.Overseas_work_experience = new SelectList(db.Overseas_experience, "Overseas_work_experience", "Overseas_work_experience", points_Calculator.Overseas_work_experience);
            ViewBag.Partner_skills = new SelectList(db.Partner_level, "Partner_skills", "Partner_skills", points_Calculator.Partner_skills);
            ViewBag.Qualification = new SelectList(db.Qualification_skills, "Qualification", "Qualification", points_Calculator.Qualification);
            return View(points_Calculator);
        }
        public ActionResult Above80()
        {
            ViewBag.points= Session["points"];
            return View();
        }

        public ActionResult Below80()
        {
            ViewBag.points = Session["points"];
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
