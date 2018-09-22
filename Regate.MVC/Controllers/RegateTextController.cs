using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateTextController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
