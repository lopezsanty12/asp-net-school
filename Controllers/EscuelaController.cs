using System;
using Microsoft.AspNetCore.Mvc;
using Platzi_AspNet.Models;

namespace Platzi_AspNet.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.UniqueId= Guid.NewGuid().ToString();
            escuela.Nombre = "School Cacao";
            escuela.Dirección = "Zona 4, 43-2 avenida";
            escuela.Ciudad = "Guatemala";
            escuela.Pais = "Guatemala";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = System.DateTime.Today;
            return View(escuela);
        }
    }
}