using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class StatisticController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            //ViewBag.skillCount = db.TblSkill.Count(); // Controller to View
            ViewBag.countProjeTalebi = db.CountProjeTalebi().FirstOrDefault();
            ViewBag.technologyCount = db.TblTechnology.Count();
            ViewBag.csharpValue = db.TblTechnology.Where(x => x.TechnologyTitle == "c#").Select(y => y.TechnologyValue).FirstOrDefault();
            ViewBag.contactCount = db.TblContact.Count();
            ViewBag.subjectTesekkur = db.TblContact.Where(x => x.Subject == 1).Count();
            ViewBag.sumTechnologyValue = db.TblTechnology.Sum(x => x.TechnologyValue);
            ViewBag.averageTechnologyValue = db.TblTechnology.Average(X => X.TechnologyValue);
            ViewBag.GetBy3ID = db.TblSkill.Where(x=>x.SkillID==3).Select(y=>y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnology = db.TblTechnology.Max(x => x.TechnologyValue);
            return View();
        }
    }
}