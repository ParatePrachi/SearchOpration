using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyMVC.Models;
using System.IO;

namespace DummyMVC.Controllers
{
    public class DownloadFileController : Controller
    {
        // GET: DownloadFile
        public ActionResult Index()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Download/"));
            List<DownloadFileModel> files = new List<DownloadFileModel>();
            foreach (string filePath in filePaths)
            {
                files.Add(new DownloadFileModel { FileName = Path.GetFileName(filePath) });
            }
            return View(files);
        }
        public FileResult DownloadFile(string fileName)
        {
            string path = Server.MapPath("~/Download/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "application/octet-stream", fileName);
        }


    }
}