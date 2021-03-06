using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sistema_toma_turnos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_toma_turnos.Controllers
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
            return View("Inicio");
        }

        //ENVIAR INFORMACION DE LA VISTA AL CONTROLADOR 
        //[HttpPost]
        //public IActionResult Index(ticket ticket)
        //{
        //    //SI ES EXITOSO EL HTTPPOST ME RETORNA A LA VISTA DE TIPO DE TICKET
        //    return RedirectToAction("Tipo");
        //}

        public IActionResult Tipo()
        {
            return View();

        }
        public IActionResult Categorias()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
