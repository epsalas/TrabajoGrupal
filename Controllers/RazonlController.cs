using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrabajoGrupal.Models;
using TrabajoGrupal.Data;

namespace TrabajoGrupal.Controllers
{
    public class RazonlController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public RazonlController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult RazonCorriente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RazonCorriente1(Razones razones){
            
            if (ModelState.IsValid)
            {
                double rcorriente= razones.acorriente1/razones.pcorriente1;
                razones.Mensaje1=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

        [HttpPost]
        public IActionResult RazonCorriente2(Razones razones){
            
            if (ModelState.IsValid)
            {
                double rcorriente= razones.acorriente2/razones.pcorriente2;
                razones.Mensaje2=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

        [HttpPost]
        public IActionResult RazonCorriente3(Razones razones){
            
            if (ModelState.IsValid)
            {
                double rcorriente= razones.acorriente3/razones.pcorriente3;
                razones.Mensaje3=rcorriente;
            }
            return View("RazonCorriente",razones);
        }




        [HttpPost]
        public IActionResult PruebaAcida1(Razones razones){
            
            if (ModelState.IsValid)
            {   
                double resta=razones.acorriente4-razones.inventario4;
                double rcorriente= resta/razones.pcorriente4;
                razones.Mensaje4=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

        [HttpPost]
        public IActionResult PruebaAcida2(Razones razones){
            
            if (ModelState.IsValid)
            {   
                double resta=razones.acorriente5-razones.inventario5;
                double rcorriente= resta/razones.pcorriente5;
                razones.Mensaje5=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

        [HttpPost]
        public IActionResult PruebaAcida3(Razones razones){
            
            if (ModelState.IsValid)
            {   
                double resta=razones.acorriente6-razones.inventario6;
                double rcorriente= resta/razones.pcorriente6;
                razones.Mensaje6=rcorriente;
            }
            return View("RazonCorriente",razones);
        }




        [HttpPost]
        public IActionResult IndiceLiquidez1(Razones razones){
            
            if (ModelState.IsValid)
            {
                double rcorriente= razones.adisponible1/razones.pcorriente7;
                razones.Mensaje7=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

        [HttpPost]
        public IActionResult IndiceLiquidez2(Razones razones){
            
            if (ModelState.IsValid)
            {
                double rcorriente= razones.adisponible2/razones.pcorriente8;
                razones.Mensaje8=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

        [HttpPost]
        public IActionResult IndiceLiquidez3(Razones razones){
            
            if (ModelState.IsValid)
            {
                double rcorriente= razones.adisponible3/razones.pcorriente9;
                razones.Mensaje9=rcorriente;
            }
            return View("RazonCorriente",razones);
        }

    }
}