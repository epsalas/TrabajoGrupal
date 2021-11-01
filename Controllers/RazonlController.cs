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
    }
}