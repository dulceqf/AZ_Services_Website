using Microsoft.AspNetCore.Mvc;

namespace AZ_Services.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Individual services
        public IActionResult HVAC()
        {
            return View();
        }

        public IActionResult Plumbing()
        {
            return View();
        }

        public IActionResult Electrical()
        {
            return View();
        }
    }

}
