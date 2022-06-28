using System;
using System.Linq;
using Biblioteca.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuarioLoginController : Controller
    {
        private BibliotecaContext contexto;

        public UsuarioLoginController (Modelo.BibliotecaContext context)
        {
            contexto = context;
        }

        public IActionResult Login(string usuario, string clave)
        {
            ViewBag.mensaje = "";
            var ses = HttpContext.Session.GetString(Constants.USUARIOID);
            if (usuario != null)
            {
                // buca el usuario si existe
                string text = usuario.ToLower();
                var u = (from l in this.contexto.usuarios
                         where l.usuario.Equals(usuario)
                         select l).FirstOrDefault();
                // si la clave oincide, activa la session
                if (u != null && u.clave.Equals(clave))
                {
                    ViewBag.usuario = u;
                    HttpContext.Session.SetString(Constants.USUARIOID, "" + u.UsuarioId);
                    ViewBag.mensaje = "Ingreso Correcto";
                }
                else
                {
                    // si no coincide marca al usuario no logueado
                    ViewBag.mensaje = "Clave incorrecta";
                    ViewBag.usuario = null;
                }
            }
            else
            {
                var idusuario = HttpContext.Session.GetString(Constants.USUARIOID);
                // el usuario no esta logueado
                if (idusuario == null) {
                    ViewBag.usuario = null;
                }
                else { 
                    // el usuario esta logueado
                    Int32 id = Int32.Parse(idusuario);
                    var u = (from l in this.contexto.usuarios
                             where l.UsuarioId.Equals(id)
                             select l).FirstOrDefault();
                    ViewBag.usuario = u;
            }
            }
            return View();
        }
    }
}