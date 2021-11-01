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
    public class EstadosfController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public EstadosfController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ACorriente()
        {
                                                 //Expresion   
            var listContactos=_context.Cuentas.OrderBy(s => s.ID).Where(e => e. tipocuenta == "Activos Corrientes").ToList();
            return View("ACorriente",listContactos);

        }

        public IActionResult ANCorriente()
        {
                                                 //Expresion   
            var listContactos=_context.Cuentas.OrderBy(s => s.ID).Where(e => e. tipocuenta == "Activos No Corrientes").ToList();
            return View("ANCorriente",listContactos);

        }


        public IActionResult Patrimonio()
        {
                                                 //Expresion   
            var listContactos=_context.Cuentas.OrderBy(s => s.ID).Where(e => e. tipocuenta == "Patrimonio").ToList();
            return View("Patrimonio",listContactos);

        }


        public IActionResult PCorriente()
        {
                                                 //Expresion   
            var listContactos=_context.Cuentas.OrderBy(s => s.ID).Where(e => e. tipocuenta == "Pasivos Corrientes").ToList();
            return View("PCorriente",listContactos);

        }

        public IActionResult PNCorriente()
        {
                                                 //Expresion   
            var listContactos=_context.Cuentas.OrderBy(s => s.ID).Where(e => e. tipocuenta == "Pasivos No Corrientes").ToList();
            return View("PNCorriente",listContactos);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public  IActionResult Create(Cuentas objContacto){

            if (ModelState.IsValid)
            {
                 objContacto.Mensaje = "Registrado";

                _context.Add(objContacto);
                _context.SaveChanges();

                 return View(objContacto);   
            }
            return View();
        }

        // GET: http://localhost:5000/Contacto/Edit/6 MUESTRA Contacto
        public IActionResult Edit(int? id)
        {
            if(id == null){
                return NotFound();
            }
            var contacto = _context.Cuentas.Find(id);
            if(contacto == null){
                return NotFound();
            }
            return View(contacto);
        }

        //POST: http://localhost:5000/Contacto/Edit/ graba contacto
        [HttpPost]
        public IActionResult Edit(int id, Cuentas contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.Mensaje = "Actualizado";
                _context.Update(contacto);
                _context.SaveChanges();
            }
            return View(contacto);
        }


        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        public IActionResult Delete(int? id)
        {
            var contacto = _context.Cuentas.Find(id);
            _context.Cuentas.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}