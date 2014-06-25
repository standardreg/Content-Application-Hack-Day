using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQH.Repositories;

namespace StandardRegisterHackathon.Controllers
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

        public ActionResult Tip()
        {
            var tipRepo = new TipRepo();

            var tipList = tipRepo.GetTips();

            return View();
        }

        public ActionResult Topics()
        {
            return View();
        }
    }
}