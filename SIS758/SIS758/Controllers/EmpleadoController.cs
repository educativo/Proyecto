using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using SIS758.Models;

namespace SIS758.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/

        public ActionResult Index()
        {
            return View();
        }
  
        public ActionResult registrar()
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.emp = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp select f).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult registrar(registraremp r)
        {
            ConectorDataContext db = new ConectorDataContext();
            
            if (ModelState.IsValid)
            {
                
                int l;
                l = db.Empleados.Where(n=>n.CodEmp==r.Di).Count();
                //.Where(n => n.CodCli == r.Di).Count();
                if (l == 0)
                {
                    if (r.e == null)
                         r.e = "";
                     if (r.t == null)
                         r.t = "0";
                     db.Ins_emp_p(r.Nombre, r.Ap, r.Am, r.Di, r.Td, 1, r.ciu, Convert.ToInt32(r.t, 10), r.e, r.dir, r.fecha, r.ca, r.Tu);
                }
                else
                {
                }
            }
            ViewBag.emp = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp select f).ToList();
            /*var fila = from f1 in db.Personas
                       join f2 in db.Empleados on f1.DocId equals f2.CodEmp
                       where f1.DocId == f2.CodEmp
                       select new
                       {
                           Did = f1.DocId,
                           Tdoc=f1.TipoDoc,
                           Nomb = f1.Nombre,
                           App= f1.ApPat,
                           Apm = f1.ApMat,
                           Pa  = "Bolivia",
                           Ciu = f1.Ciudad,
                           Dir = f1.Direccion,
                           Em=f1.Email,
                           Tel=f1.Telefono,
                           Fecha=f1.FechNac,
                           Car = f2.Cargo,
                           Tur = f2.Turno
                       };*/
            return View();
        }
        public ActionResult actualizar(string id)
        {
            ConectorDataContext db = new ConectorDataContext();
            ViewBag.emp = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp where id == j.CodEmp select f).ToList();
            ViewBag.usu = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp where id == j.CodEmp select j).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult actualizar(actualizaremp r)
        {
            ConectorDataContext db = new ConectorDataContext();
            if (ModelState.IsValid)
            {
                
                db.UpdaEmpl(r.bu, r.Nombre, r.Ap, r.Am, r.Di, r.Td, 1, r.ciu, Convert.ToInt32(r.t, 10), r.e, r.dir, r.fecha, r.ca, r.Tu);
                return Redirect("../registrar");
            }
            ViewBag.emp = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp where r.bu == j.CodEmp select f).ToList();
            ViewBag.usu = (from f in db.Personas join j in db.Empleados on f.DocId equals j.CodEmp where r.bu == j.CodEmp select j).ToList();
            return View();
        }
        public ActionResult eliminar(string id)
        {
            ConectorDataContext db = new ConectorDataContext();
            db.eli_emp(id);
            return Redirect("../registrar");
        }
        public ActionResult detalle()
        {

           /* Guid id=
            var fila = from f1 in db.Personas
                       join f2 in db.Empleados on f1.DocId equals f2.CodEmp
                       where f1.DocId == id//f2.CodEmp
                       select new
                       {
                           Did = f1.DocId,
                           Tdoc = f1.TipoDoc,
                           Nomb = f1.Nombre,
                           App = f1.ApPat,
                           Apm = f1.ApMat,
                           Pa = "Bolivia",
                           Ciu = f1.Ciudad,
                           Dir = f1.Direccion,
                           Em = f1.Email,
                           Tel = f1.Telefono,
                           Fecha = f1.FechNac,
                           Car = f2.Cargo,
                           Tur = f2.Turno
                       };
            ViewBag.Did = fila.ToArray()[0].Did;
            ViewBag.Tdoc = fila.ToArray()[0].Tdoc;
            ViewBag.Nomb = fila.ToArray()[0].Nomb;
            ViewBag.App = fila.ToArray()[0].App;
            ViewBag.Apm = fila.ToArray()[0].Apm;
            ViewBag.Pa = fila.ToArray()[0].Pa;
            ViewBag.Ciu = fila.ToArray()[0].Ciu;
            ViewBag.Dir = fila.ToArray()[0].Dir;
            ViewBag.Em = fila.ToArray()[0].Em;
            ViewBag.Tel = fila.ToArray()[0].Tel;
            ViewBag.Car = fila.ToArray()[0].Car;
            ViewBag.Tur = fila.ToArray()[0].Tur;*/
            return View();
        }
    }
}
