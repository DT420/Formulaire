using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Initiation.Models;

namespace Initiation.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Form()
        {
            Yo();
            return View();
        }

        [HttpPost] //Envoi du formulaire
        public ActionResult Form(FormModel model)
        {
            Yo();
            if (ModelState.IsValid)
            {
                TempData["info"] = "Votre commentaire à été envoyé!";
                return RedirectToAction("Index", "Home");
            }
            else
                return View();

        }

        private void Yo()
        {
            ViewBag.ImgUrl = "http://www.publicdomainpictures.net/pictures/50000/nahled/smiley-silhouette.jpg";
            ViewBag.Message1 = "Yo";
            ViewData["Message2"] = "What's up?";
        }

    }
}
