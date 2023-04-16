using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class DefaultController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialBrand()
        {
            return PartialView();
        }

        public PartialViewResult PartialProjects()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCounter()
        {
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.avgTechnologyValue = db.TblTechnology.Average(x=>x.TechnologyValue);
            ViewBag.happyCustomer = 38;
            return PartialView();
        }

        public PartialViewResult PartialTechnology()
        {
            var valeus = db.TblTechnology.ToList();
            return PartialView(valeus);
        }

        public PartialViewResult PartialService()
        {
            var valeus = db.TblService.ToList();
            return PartialView(valeus);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
    }
}