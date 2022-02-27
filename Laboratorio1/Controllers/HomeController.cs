using Laboratorio1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Practica(String Nombre,Double DatoN1,Double DatoN2, Double DatoN3, Double DatoN4, Double DatoN5, Double DatoN6)
        {
            String NombreCompleto = Nombre;
            Double resultado = DatoN1 + DatoN2 + DatoN3 + DatoN4 + DatoN5 + DatoN6;

            Double resultadofinal =resultado / 6;
            ViewBag.Nombre = Nombre;
            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.DatoN3V = DatoN3;
            ViewBag.DatoN4V = DatoN4;
            ViewBag.DatoN5V = DatoN5;
            ViewBag.DatoN6V = DatoN6;
            ViewBag.VariableAEnviar = resultadofinal;
            return View();
        }
    }
}
