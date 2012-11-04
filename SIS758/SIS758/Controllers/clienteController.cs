using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SIS758.Models;

namespace SIS758.Controllers
{
    public class clienteController : Controller
    {
        //
        // GET: /cliente/

        public ActionResult Registrar()
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.usu = (from f in db.Personas join j in db.Clientes on f.DocId equals j.CodCli select f).ToList();
            return View();
        }

        public ActionResult actualizar(string id)
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.usu2 = (from f in db.Personas join j in db.Clientes on f.DocId equals j.CodCli where id == f.DocId select f).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult actualizar(actualizar r)
        {
            ConectorDataContext db = new ConectorDataContext();    
            if (ModelState.IsValid) {
               
                //ViewBag.usu2 = (from f in db.Personas join j in db.Clientes on f.DocId equals j.CodCli where id == f.DocId select f).ToList();
                db.Updacliente(r.bu, r.Nombre, r.Ap, r.Am, r.Di, r.Td, 1, r.ciu, Convert.ToInt32(r.t, 10), r.e, r.dir, r.fecha);
                return Redirect("../registrar");
            }
            ViewBag.usu2 = (from f in db.Personas join j in db.Clientes on f.DocId equals j.CodCli where r.bu == f.DocId select f).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(registrar r)
        {
            ConectorDataContext db = new ConectorDataContext();
            if (ModelState.IsValid)
            {
               
                int l =0 ;

                 l=db.Clientes.Where(n => n.CodCli == r.Di).Count();
                 if (l == 0)
                 {
                     if (r.e == null)
                         r.e = "";
                     if (r.t == null)
                         r.t = "0";
                     db.Ins_cli_p(r.Nombre, r.Ap, r.Am, r.Di, r.Td, 1, r.ciu, Convert.ToInt32(r.t, 10), r.e, r.dir, r.fecha);
                 }
                 else
                 {
                     
                 }
               
            }
            
            ViewBag.usu = (from f in db.Personas join j in db.Clientes on f.DocId equals j.CodCli select f).ToList();
            return View();
            
        }
        public ActionResult detalle()
        {
            return View();
        }
        public ActionResult index(string id)
        {
            ViewBag.nom = id;
            return View();
        }
        public ActionResult actu()
        {
            return View();
        }
        public ActionResult eliminar(string id)
        {
            ConectorDataContext db = new ConectorDataContext();
            db.eli_cli(id);
            return Redirect("../registrar");
        }
        public JsonResult loadData()
        {

            ConectorDataContext db =new ConectorDataContext();
            return Json(new { lista = db.Personas.ToList(), nombres = db.Personas.Select(m => m.DocId).ToList() });
           // return Json(new { lista = db.usuarios.ToList(), nombres = db.usuarios.Select(a => a.nombre).ToList() });
        }
    }
}
