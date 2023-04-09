using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResmeProject.Models;

namespace ResmeProject.Controllers
{
    public class ContactController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
    }
}

//Kategori Crud işlemleri yapılacak-----bitti
//Profile Crud işlemleri Tamamlanacak ---- Bitti
//Proje Crud işlemleri Kısmı tamamlanacak
//İilişkili tabloların mvc'de kullanımı, prosedür kullanımı
//isttiksel entity framework metotları