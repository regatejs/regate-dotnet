using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
