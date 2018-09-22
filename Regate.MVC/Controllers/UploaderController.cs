using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class UploaderController : Controller
    {
        public ActionResult File(string field = "")
        {
            ViewBag.Field = field;
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(string field, IFormFile file)
        {
            ViewBag.Field = field;
            ViewBag.FileName = "uploaded-file-name.pdf";

            return View();
        }
    }
}
