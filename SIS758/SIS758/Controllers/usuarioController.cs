using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SIS758.Models;

namespace SIS758.Controllers
{
    public class usuarioController : Controller
    {
        //
        // GET: /usuario/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult registrar()
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.emp = (from f in db.Personas join j in db.Clientes  on f.DocId equals j.CodCli  select f).ToList();
            ViewBag.usu = (from f in db.Personas join u in db.Usuarios on f.DocId equals u.CodUs select f).ToList();
            return View();
        }
        public ActionResult alta(string id)
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.usu2 = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp where id == f.DocId select f).ToList();
            return Redirect("../registrar");
        }

    }
}
