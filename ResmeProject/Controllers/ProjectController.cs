using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class ProjectController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var value = db.TblProject.ToList();
            return View(value);
        }

        [HttpGet]

        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.TblProject.Find(id);
            db.TblProject.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.TblProject.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value = db.TblProject.Find(p.ProjectID);
            value.ProjectTitle = p.ProjectTitle;
            value.ProjectDescription = p.ProjectDescription;
            value.ProjectImageUrl = p.ProjectImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}