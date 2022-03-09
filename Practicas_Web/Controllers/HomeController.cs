using Microsoft.AspNetCore.Mvc;
using Practicas_Web.Data;
using Practicas_Web.Models;
using Practicas_Web.Models.ViewModels;
using System.Diagnostics;

namespace Practicas_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly PracticaDbContext _context;

        public HomeController(ILogger<HomeController> logger,
            PracticaDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
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

        [HttpGet]
        public CuentaViewModel obtenerCuentas()
        {

            var _model = new CuentaViewModel();

           
            var listaCuentas = _context.Datos.ToList();

            _model.listaCuentas = listaCuentas;
           

            return _model;
        }

        [HttpPost]
        public IActionResult buscarCantones(ProvinciaModel provincia)
        {
            var model = new CantonesViewModel();

            if(ModelState.IsValid)
            {
                model.listaCantones = _context.Canton
                                .Where(a => a.provincia == Convert.ToInt32(provincia.codigoProvincia))
                                .ToList();
            }

            return Json(model);
        }


        [HttpPost]
        public IActionResult guardarCuenta(CuentaModel cuentaNueva)
        {
            var _model = new CuentaViewModel();

            if (ModelState.IsValid)
            {
                _context.Datos.Add(cuentaNueva);
                _context.SaveChanges();

                var listaCuentas = _context.Datos.ToList();

                _model.listaCuentas = listaCuentas;
            }

            return Json(_model);
        }

    }
}