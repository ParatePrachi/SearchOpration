using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyMVC.Models;

namespace DummyMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveProduct(ProductModel model)
        {
            try
            {
                return Json(new { model = (new ProductModel().SaveProduct(model)) },
               JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

       
        public ActionResult DetailData(int Id)
        {
            try
            {
                return Json(new { model = (new ProductModel().DetailData(Id)) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
} 