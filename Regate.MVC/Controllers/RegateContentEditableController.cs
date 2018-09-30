using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateContentEditableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
