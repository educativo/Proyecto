using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS758.Models;
using System.Web.Security;

namespace SIS758.Controllers
{
    public class inicioController : Controller
    {
        //
        // GET: /inicio/

      
       
        public ActionResult Ingresar()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Ingresar(ingresar newuser)
        {
            if (ModelState.IsValid)
            {
                    ConectorDataContext db = new ConectorDataContext();
                    List<aux> l= db.Usuarios.Where(a => a.CodUs == newuser.usua && a.Pass == newuser.pas ).Select(a=>new aux{ id= a.CodUs }).ToList();
                    if (l.Count != 0) {
                        string al=db.Personas.Where(a => a.DocId == newuser.usua).First().DocId;
                        l = db.Personas.Where(a => a.DocId == newuser.usua).Select(a => new aux {id=a.DocId, nom = a.Nombre }).ToList();
                        ViewBag.lo = l[0].nom;
                        ViewBag.nom = l[0].nom;
                        return RedirectToAction("index", "cliente");
                    }
            }
            
            return View();
        }
        public ActionResult Index()
        {
            return RedirectToAction("ingresar", "inicio");
            return View();
        }
    }
}
