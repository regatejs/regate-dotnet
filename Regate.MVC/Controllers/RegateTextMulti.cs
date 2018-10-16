using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateTextMultiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
