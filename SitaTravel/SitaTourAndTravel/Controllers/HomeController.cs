using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitaTourAndTravel.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Star Scaff Shuttering and Fabrication";
        }
        public ActionResult Submenu()
        {
            return View();
        }       
    }
}