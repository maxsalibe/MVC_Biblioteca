using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class BibliotecaReservasController : Controller
    {
        private Modelo.BibliotecaContext contexto;

        public BibliotecaReservasController (Modelo.BibliotecaContext context)
        {
            contexto = context;
        }
        
        public ActionResult Index()
        {
            var consulta = from l in contexto.libros
                           orderby l.titulo
                           select l;

            var list = filtrarLibrosDisponibles(consulta);
            ViewBag.libros = list;

            return View();
        }

        private List<Libro> filtrarLibrosDisponibles(IQueryable<Libro> consulta)
        {
            var list = new List<Libro>();
            foreach (var item in consulta)
            {
                // cuenta los prestamos del libro vs las devoluciones
                var prestado = contexto.prestamos.Count(a => a.libro.libroId == item.libroId && !a.devolucion);
                var devuelto = contexto.prestamos.Count(a => a.libro.libroId == item.libroId && a.devolucion);
                // si no coincide se asume que el libro esta prestado
                if (prestado == devuelto)
                    list.Add(item);
            }
            return list;
        }

        public IActionResult Buscar (String nombre)
        {
            if (nombre == null)
                nombre = "";
            var text = nombre.ToLower ();
            var consulta = from l in this.contexto.libros
                           where l.titulo.ToLower ().Contains (text)
                           orderby l.titulo
                           select l;
            var list = filtrarLibrosDisponibles(consulta);
            ViewBag.libros = list;
            return View();
        }
    }
}
