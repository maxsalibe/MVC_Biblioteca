using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class LectorSelectorController : Controller
    {
        private Modelo.BibliotecaContext contexto;

        public LectorSelectorController(Modelo.BibliotecaContext context)
        {
            contexto = context;
        }

        public ActionResult Index(String? nombre, int? libro)
        {
            // selecciono los lectores por nombre
            var consulta = from l in contexto.lectores
                           where nombre == null || (l.Apellido + " " + l.Nombre).Contains(nombre)
                           orderby l.Apellido + " " + l.Nombre
                           select l;
            ViewBag.lectores = consulta;
            // al venir libro, lo registro para que la vista lo muestre
            if (libro != null) {
                var libro1 = from l in contexto.libros
                            where l.libroId == libro
                            select l;
                ViewBag.libro = libro1.FirstOrDefault ();
            } else
                ViewBag.libro = null;
            return View();
        }
    }
}
