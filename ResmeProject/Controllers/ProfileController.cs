using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class ProfileController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var value = db.TblProfile.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProfile(TblProfile p)
        {
            db.TblProfile.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProfile(int id)
        {
            var values = db.TblProfile.Find(id);
            db.TblProfile.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var values = db.TblProfile.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProfile(TblProfile p)
        {
            var value = db.TblProfile.Find(p.ProfileID);
            value.ProfileTitle = p.ProfileTitle;
            value.ProfileDescription = p.ProfileDescription;
            value.Mail = p.Mail;
            value.Adress = p.Adress;
            value.Phone = p.Phone;
            value.SocialMedia1 = p.SocialMedia1;
            value.SocialMedia2 = p.SocialMedia2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}