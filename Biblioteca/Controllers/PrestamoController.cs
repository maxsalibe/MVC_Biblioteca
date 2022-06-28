using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Modelo;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class PrestamoController : Controller
    {
        private Modelo.BibliotecaContext contexto;

        public PrestamoController (Modelo.BibliotecaContext context)
        {
            contexto = context;
        }

        public ActionResult Index(int lector, int libro)
        {
            var qlibros = from l in contexto.libros
                           where l.libroId == libro
                           select l;
            var libro1 = qlibros.FirstOrDefault ();
            ViewBag.libro = libro1;

            var qlector = from l in contexto.lectores
                          where l.lectorId == lector
                          select l;
            var lector1 = qlector.FirstOrDefault();
            ViewBag.lector = lector1;
            if (EstaPrestado(lector, libro))
            {
                ViewBag.error = true;
            }
            else
            {
                var idusuario = HttpContext.Session.GetString(Constants.USUARIOID);
                Int32 id = Int32.Parse(idusuario);

                var u = (from a in contexto.usuarios
                        where a.UsuarioId == id
                        select a).FirstOrDefault ();
                ViewBag.error = false;
                Prestamo p = new Prestamo
                {
                    devolucion = false,
                    usuario = u,
                    lector = lector1,
                    libro = libro1,
                    fechaHora = DateTime.Now
                };
                contexto.Add(p);
                contexto.SaveChanges();
            }
            return View();
        }

        public ActionResult LibrosPrestados (int lector)
        {
            List<LibroEstado> list = new List<LibroEstado> ();
            var q = (from p in contexto.prestamos
                     where p.lector.lectorId == lector
                     select new LibroEstado () { 
                         libroId = p.libro.libroId, 
                         titulo = p.libro.titulo, 
                         rutaimagen = p.libro.rutaimagen, 
                         prestado = contexto.prestamos.Count(a => a.libro.libroId == p.libro.libroId && a.lector.lectorId == lector && !a.devolucion) !=
                                    contexto.prestamos.Count(a => a.libro.libroId == p.libro.libroId && a.lector.lectorId == lector && a.devolucion)
                                }
                    );
            foreach (var item in q)
            {
                list.Add(item);
            }
            ViewBag.lector = lector;
            ViewBag.libros = list;
            return View();
        }
    

        public ActionResult Devolucion (int lector, int libro, String backurl)
        {
            var qlibros = from l in contexto.libros
                            where l.libroId == libro
                            select l;
            var libro1 = qlibros.FirstOrDefault();
            ViewBag.libro = libro1;

            var qlector = from l in contexto.lectores
                            where l.lectorId == lector
                            select l;
            var lector1 = qlector.FirstOrDefault();
            ViewBag.lector = lector1;

            if (EstaPrestado(lector, libro))
            {
                var idusuario = HttpContext.Session.GetString(Constants.USUARIOID);
                Int32 id = Int32.Parse(idusuario);

                var u = (from a in contexto.usuarios
                         where a.UsuarioId == id
                         select a).FirstOrDefault();
                ViewBag.error = false;
                Prestamo p = new Prestamo
                {
                    devolucion = true,
                    usuario = u,
                    lector = lector1,
                    libro = libro1,
                    fechaHora = DateTime.Now
                };
                contexto.Add(p);
                contexto.SaveChanges();
            } else {
                ViewBag.error = true;
            }
            ViewBag.backurl = backurl;
            return View();
        }

        private bool EstaPrestado(int lector, int libro) {
            return contexto.prestamos.Count(a => a.libro.libroId == libro && a.lector.lectorId == lector && !a.devolucion) !=
                        contexto.prestamos.Count(a => a.libro.libroId == libro && a.lector.lectorId == lector && a.devolucion);
        }
    }
}

