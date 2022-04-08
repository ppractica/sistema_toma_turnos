using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_toma_turnos.Controllers
{
    public class VistaController : Controller
    {
        public IActionResult Vista()
        {
            return View();
        }
    }
}
