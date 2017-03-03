using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCGetCar.Service;
using System.Threading.Tasks;

namespace MVCGetCar.Controllers
{
    public class HomeController : Controller
    {
        private CarService service = new CarService();

        public async Task<ActionResult> Index()
        {

            return View("index",
                await service.GetCarsAsync()
            );
        }

        public ActionResult IndexSync()
        {

            return View("index",
                service.GetCars()
            );
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