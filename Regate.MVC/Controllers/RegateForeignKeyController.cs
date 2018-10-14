using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class RegateForeignKeyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            var model = new List<IdTitle>
            {
                new IdTitle("1", "Apple"),
                new IdTitle("2", "Amazon"),
                new IdTitle("3", "Yahoo"),
                new IdTitle("4", "Oracle"),
                new IdTitle("5", "Microsoft"),
                new IdTitle("6", "StackOverflow"),
                new IdTitle("7", "GitHub"),
                new IdTitle("8", "Google"),
            };

            return Json(model);
        }
    }

    public class IdTitle
    {
        public IdTitle(string id, string title)
        {
            Id = id;
            Title = title;
        }

        public string Id { get; set; }
        public string Title { get; set; }
    }
}
