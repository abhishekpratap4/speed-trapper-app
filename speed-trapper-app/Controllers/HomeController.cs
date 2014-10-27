using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpeedTrapApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public static int speedLimit = 200;
        public ActionResult Index()
        {
            ViewBag.SpeedLimit = speedLimit;
            return View();
        }

        [HttpPost]
        public ActionResult SetMaxSpeedLimit(string txtSpeed)
        {
            HomeController.speedLimit = Convert.ToInt16(txtSpeed.ToString());
            ViewBag.SpeedLimit = speedLimit;
            return View("Index");
        }

    }
}
