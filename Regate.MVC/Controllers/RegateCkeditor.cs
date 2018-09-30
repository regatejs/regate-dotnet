using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateCkeditorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
