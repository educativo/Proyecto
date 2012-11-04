using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS758.Models;

namespace SIS758.Controllers
{
    public class PaisController : Controller
    {
        //
        // GET: /Pais/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistrarPa()
        {
            return View();
        }
        public ActionResult ActualizarPa()
        {
            return View();
        }
    }
    /*public class estadoController : Controller
    { 
    }??????????????????????*/
}
