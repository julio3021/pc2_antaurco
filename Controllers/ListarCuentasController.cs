using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc2_antaurco.Data;
using pc2_antaurco.ViewModel;
using pc2_antaurco.Models;

namespace pc2_antaurco.Controllers
{
    public class ListarCuentasController : Controller
    {
        private readonly ILogger<ListarCuentasController> _logger;
        private readonly ApplicationDbContext _context;

        public ListarCuentasController(ILogger<ListarCuentasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Acción que carga la vista principal con el listado de cuentas
        public IActionResult Index()
        {
            // Obtiene todas las cuentas bancarias de la base de datos
            var cuentas = _context.DataCuentaBancaria.ToList();

            // Crea el ViewModel con las cuentas obtenidas
            var viewModel = new CuentaBancariaViewModel
            {
                ListarCuentaBancaria = cuentas // Lista de cuentas para la tabla
            };

            return View(viewModel); // Retorna la vista con el modelo
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}