using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GTP_testDrive.Models;

namespace GTP_testDrive.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult getItems()
        {
            List<Items> list = new List<Items>();
            list.Add(new Items(DateTime.Now, "Item #1", "Desc #1"));
            list.Add(new Items(DateTime.Now.AddMinutes(-2), "Item #2", "Description of item #2"));
            list.Add(new Items(DateTime.Now.AddMinutes(-12), "Item #3", "The longer description of ian item"));
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}