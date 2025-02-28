using SubatOdev2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubatOdev2.Controllers
{
    public class DefaultController : Controller
    {
        VeritabaniContext db = new VeritabaniContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}