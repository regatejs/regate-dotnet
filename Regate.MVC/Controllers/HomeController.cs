using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
