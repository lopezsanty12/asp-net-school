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
            escuela.AnioFundacion=2005;
            escuela.EscuelaId= Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            return View(escuela);
        }
    }
}