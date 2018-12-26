using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateSwitchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
