using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS758.Models;

namespace SIS758.Controllers
{
    public class habitacionController : Controller
    {
        //
        // GET: /habitacion/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult registrarhab()
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.habi = (from i in db.Habitacions select i).ToList();

            return View();
        }
        [HttpPost]
        public ActionResult registrarhab(registrarhab r)
        {
            ConectorDataContext db = new ConectorDataContext();
            if (ModelState.IsValid)
            {

                int l = 0;
                l = db.Habitacions.Where(n => n.CodHab == r.Nro).Count();
                if (l == 0)
                {
                    Convert.ToDouble(r.Pres);
                    db.Reg_Habi(r.Tipo, r.Nro, Convert.ToDouble(r.Pres), r.Des, r.Est);
                }
            }
            ViewBag.habi = (from i in db.Habitacions select i).ToList();
            return View();
        }
        public ActionResult eliminar(string id, string ti)
        {
            ConectorDataContext db = new ConectorDataContext();
            db.eli_hab(id, ti);
            return Redirect("../registrarhab");
        }
        public ActionResult detalle()
        {

            return View();
        }
        public ActionResult Actualizarhab(string id)
        {
            ConectorDataContext db = new ConectorDataContext();
                ViewBag.hab = (from f in db.Habitacions where id == f.CodHab select f).ToList();
            
            return View();
        }
        [HttpPost]
        public ActionResult Actualizarhab(Acthab r)
        {
            ConectorDataContext db = new ConectorDataContext();
            if (ModelState.IsValid)
            {
                Convert.ToDouble(r.Pres);
                db.Updambiente(r.bu, r.Tipo, r.Nro, Convert.ToDouble(r.Pres), r.Des, r.Est);
                return Redirect("../registrarhab");
            }
            ViewBag.hab = (from f in db.Habitacions where r.bu == f.CodHab select f).ToList();
            return View();
        }
    }
}
