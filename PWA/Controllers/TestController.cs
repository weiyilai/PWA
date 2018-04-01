using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWA.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajax()
        {
            return Json(new { isSuccess = true }, JsonRequestBehavior.AllowGet);
        }
    }
}