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
    public class RazonaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public RazonaController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult RazonActividad()
        {
            return View();
        }
    //razon corriente
        //CXCPromedio
        [HttpPost]
        public IActionResult CXCProm1(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= razonesa.ccinicial1 - razonesa.ccfinal1;
                ra= ra/2;
                razonesa.Mensaje1= Math.Round(ra,3);
                razonesa.ccp1=razonesa.Mensaje1;
            }
            return View("RazonActividad",razonesa);
        }
        
        [HttpPost]
        public IActionResult CXCProm2(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= razonesa.ccinicial2 - razonesa.ccfinal2;
                ra= ra/2;
                razonesa.Mensaje2= Math.Round(ra,3);
                razonesa.ccp2=razonesa.Mensaje2;
            }
            return View("RazonActividad",razonesa);
        }

        [HttpPost]
        public IActionResult CXCProm3(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= razonesa.ccinicial3 - razonesa.ccfinal3;
                ra= ra/2;
                razonesa.Mensaje3= Math.Round(ra,3);
                razonesa.ccp3=razonesa.Mensaje3;

            }
            return View("RazonActividad",razonesa);
        }


        //Rotacion CxC
        [HttpPost]
        public IActionResult RotacionCC1(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= razonesa.vnetas / razonesa.ccp1;
                razonesa.Mensaje4= Math.Round(ra,3);
                razonesa.rcc1=razonesa.Mensaje4;
            }
            return View("RazonActividad",razonesa);
        }

        [HttpPost]
        public IActionResult RotacionCC2(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= razonesa.vnetas2 / razonesa.ccp2;
                razonesa.Mensaje5= Math.Round(ra,3);
                razonesa.rcc2=razonesa.Mensaje5;
            }
            return View("RazonActividad",razonesa);
        }

        [HttpPost]
        public IActionResult RotacionCC3(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= razonesa.vnetas3 / razonesa.ccp3;
                razonesa.Mensaje6= Math.Round(ra,3);
                razonesa.rcc3=razonesa.Mensaje6;
            }
            return View("RazonActividad",razonesa);
        }


        //Dias de cuentas x cobrar

        [HttpPost]
        public IActionResult Dcxc1(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= 360/ razonesa.rcc1;
                razonesa.Mensaje7= Math.Round(ra,3);
                razonesa.ccd1=razonesa.Mensaje7;
            }
            return View("RazonActividad",razonesa);
        }

        [HttpPost]
        public IActionResult Dcxc2(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= 360/ razonesa.rcc2;
                razonesa.Mensaje8= Math.Round(ra,3);
                razonesa.ccd2=razonesa.Mensaje8;
            }
            return View("RazonActividad",razonesa);
        }

        [HttpPost]
        public IActionResult Dcxc3(RazonesA razonesa){
            
            if (ModelState.IsValid)
            {
                double ra= 360/ razonesa.rcc3;
                razonesa.Mensaje9= Math.Round(ra,3);
                razonesa.ccd3=razonesa.Mensaje9;
            }
            return View("RazonActividad",razonesa);
        }
    }
}