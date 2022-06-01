using Microsoft.AspNetCore.Mvc;

namespace UrbanAreasProject.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View("~/Views/Home/Home.cshtml");
        }
    }
}
