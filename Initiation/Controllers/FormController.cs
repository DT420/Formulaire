using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Initiation.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Form()
        {
            ViewBag.ImgUrl = "http://www.publicdomainpictures.net/pictures/50000/nahled/smiley-silhouette.jpg";
            ViewBag.Message1 = "Yo";
            ViewData["Message2"] = "What's up?";
            return View();
        }

        [HttpPost]
        public ActionResult Form(string nom, string email,string commentaire)
        {
            return View();
        }

    }
}
