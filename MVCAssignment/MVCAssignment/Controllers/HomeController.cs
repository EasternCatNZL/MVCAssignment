using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    //calls view cshtmls
    public class HomeController : Controller
    {
        //base home page view
        public ActionResult Index()
        {
            return View();
        }

        //about view
        public ActionResult About()
        {
            ViewBag.Message = "Your application about page.";

            return View();
        }

        //contact view
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Product page view
        public ActionResult Product()
        {
            ViewBag.Message = "Our product lineup.";
            return View();
        }
    }
}