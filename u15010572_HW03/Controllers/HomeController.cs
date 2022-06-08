using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace u15010572_HW03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase files, string Type)
        {   

            if(files!=null && files.ContentLength>0)
            {
                if (Type == "document")
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var path = Path.Combine(Server.MapPath("~/Media/Documents/"), fileName);
                    files.SaveAs(path);
                }
                if (Type == "image")
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var path = Path.Combine(Server.MapPath("~/Media/Images/"), fileName);
                    files.SaveAs(path);
                }
                if (Type == "video")
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var path = Path.Combine(Server.MapPath("~/Media/Videos/"), fileName);
                    files.SaveAs(path);
                }
            }
            
            return RedirectToAction("Index");
        }
            public ActionResult About()
        {
            ViewBag.Message = "Bryony Asrie";

            return View();
        }

     


    }
}