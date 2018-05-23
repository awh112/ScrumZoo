using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScrumPenguins.Controllers
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
        
        public ActionResult Images()
        {
            return View();
        }

        public ActionResult Habitat()
        {
            return View();
        }

        public ActionResult Diet()
        {
            return View();
        }

        public ActionResult Biology()
        {
            return View();
        }

        public ActionResult Types()
        {
            return View();
        }

        public ActionResult TopTen()
        {
            return View();
        }
    }
}