using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class WebProjectsController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}