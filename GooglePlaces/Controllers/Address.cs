using Microsoft.AspNetCore.Mvc;

namespace GooglePlaces.Controllers
{
    public class Address : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
