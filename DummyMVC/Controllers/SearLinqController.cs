using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyMVC.Models;

namespace DummyMVC.Controllers
{
    public class SearLinqController : Controller
    {
        // GET: SearLinq
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSearchList(string Name)
        {
            try
            {
                return Json(new { model = (new SearLinqModel().GetSearchList(Name)) },
               JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}