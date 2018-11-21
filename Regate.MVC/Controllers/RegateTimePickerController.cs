using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateTimePickerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
