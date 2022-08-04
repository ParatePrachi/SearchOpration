using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyMVC.Models;

namespace DummyMVC.Controllers
{
    public class SreachController : Controller
    {
        // GET: Sreach
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult GetEmpSpList(string Empname)
        {
            try
            {
                return Json(new { model = (new SearchModel().GetEmpspList(Empname)) },
               JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}