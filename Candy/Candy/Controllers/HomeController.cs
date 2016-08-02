using Candy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Candy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
           return View();
        }

        public ActionResult sendMail(string to, string name, string correo, string message)
        {
            NewEmail email = new NewEmail
            {
                To = to,
                Subject = "Nuevo Record",
                name = name,
                correo = correo,
                message = message
            };
            TempData["Correo"] = email;
            return RedirectToAction("Send");
        }

        public ActionResult Send()
        {
            if (TempData["Correo"] != null)
            {
                NewEmail correo = (NewEmail)TempData["Correo"];
                correo.Send();
            }
            return RedirectToAction("Index");
        }
    }
}
