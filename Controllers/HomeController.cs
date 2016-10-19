using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace HRMEng.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Debug.WriteLine("I Type this for you");
            //ViewBag.Logo = Server.MapPath("~") + @"Images\IMG_0038.JPG";
            ViewBag.Logo = "http://www.hrmengineering.se/template/default/img/logo.png";
            ViewBag.Video =  "https://www.youtube.com/watch?v=9z6KGxwveQw";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having Trouble? send us a message";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks, we got your message";

            return View();
        }
        public ViewResult ShowForm()
        {
            Debug.WriteLine("Tjenare Hur är de?");
            return View("ShowForm");

        }
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMCV";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);
            //return Json(new { name = "serial", Value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }
    }
}