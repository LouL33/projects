using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBestWebPage.Models;

namespace TheBestWebPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new ApplicationDbContext().ThePost.OrderByDescending(o => o.TimePosted).ToList();
            return View(vm);
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
    }
}