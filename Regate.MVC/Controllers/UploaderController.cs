using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Regate.MVC.Controllers
{
    public class UploaderController : Controller
    {
        public ActionResult File(string field = "")
        {
            var markup = $@"
                <div dir='rtl'>
                    <form enctype='multipart/form-data' method='post' action=''>

                        <input type='hidden' name='field' value='{field}' />
                        <input type='file' name='file' required='required' id='fileUpload' />
                        <br />
                        <button type='submit' id='submitButton' class='btn btn-success'>آپلود فایل</button>

                    </form>
                </div>
            ";

            return new ContentResult { Content = markup, ContentType = "text/html; charset=utf-8" };
        }

        [HttpPost]
        public ActionResult File(string field, IFormFile file)
        {
            var fileName = "uploaded-file-name.pdf";

            var markup = $@"
                <script>
                    window.opener['RegateFile__setterCallback']('{field}', '{fileName}');
                    window.close();
                </script>
            ";

            return new ContentResult { Content = markup, ContentType = "text/html; charset=utf-8" };
        }
    }
}
