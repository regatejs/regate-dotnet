using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class InteractiveBooleanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangeStatus(int id, bool? status)
        {
            return Json(new { id, status });
        }
    }
}
