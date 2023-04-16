using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class AboutController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialTechnology()
        {
            var values = db.TblTechnology.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialVideo()
        {
            return PartialView();
        }

        public PartialViewResult PartialTestimonials()
        {
            var value = db.TblTestimonial.ToList();
            return PartialView(value);
        }

    }
}