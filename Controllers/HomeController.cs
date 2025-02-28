using SubatOdev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubatOdev2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(KullaniciModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mesaj = "Form başarıyla gönderildi!";
                return View("Basarili");
            }
            return View("Index", model); 
        }
    }
}
