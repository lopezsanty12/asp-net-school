using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Platzi_AspNet.Models;

namespace Platzi_AspNet.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            
            return View(new Asignatura {
                            Nombre = "Programacion",
                            UniqueId = Guid.NewGuid ().ToString ()
                            });
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura> () {
                            new Asignatura {
                            Nombre = "Matemáticas",
                            UniqueId = Guid.NewGuid ().ToString ()
                            },
                            new Asignatura {
                            Nombre = "Educación Física",
                            UniqueId = Guid.NewGuid ().ToString ()
                            },
                            new Asignatura {
                            Nombre = "Castellano",
                            UniqueId = Guid.NewGuid ().ToString ()
                            },
                            new Asignatura {
                            Nombre = "Ciencias Naturales",
                            UniqueId = Guid.NewGuid ().ToString ()
                            },
                            new Asignatura {
                            Nombre = "Programacion",
                            UniqueId = Guid.NewGuid ().ToString ()
                            }
        };

            ViewBag.CosaDinamica = "Santy";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",listaAsignaturas);
        }
    }
}