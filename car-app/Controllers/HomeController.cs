using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Random r1 = new Random();
            //ViewBag.RandomCar = "BMW";
            ViewBag.RandomSpeed = r1.Next(10, 200);

            string[] carNames = System.IO.File.ReadAllLines(@"E:\visual studio 2012\Projects\CarApp\CarApp\Resources\car-names.txt");
            Random r2 = new Random();
            ViewBag.RandomCar = carNames[r2.Next(0, 45)];
            ViewBag.Tag = "current speed";
            return View();
        }

    }
}
