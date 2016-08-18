using ApiCandyCrush.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiCandyCrush.Controllers
{
    public class MailController : ApiController
    {
        // PUT: api/Mail/5
        public void Put(int id, [FromBody]string name, string correo, string message)
        {
            ActionExecutingContext filterContext = new ActionExecutingContext();
            NewEmail email = new NewEmail
            {
                To = "j_pablo_s_s@hotmail.com",
                Subject = "Se solicita Informsacion",
                name = name,
                correo = correo,
                message = message
            };
            filterContext.HttpContext.Items["Correo"] = email;
            //return RedirectToAction("Send");
            if (filterContext.HttpContext.Items["Correo"] != null)
            {
                NewEmail oCorreo = (NewEmail)filterContext.HttpContext.Items["Correo"];
                oCorreo.Send();
            }
        }

    }
}