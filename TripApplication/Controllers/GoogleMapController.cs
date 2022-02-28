using Microsoft.AspNetCore.Mvc;

namespace TripApplication.Controllers
{
    public class GoogleMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceCalculation()
        {
            return View();
        }
    }
}
