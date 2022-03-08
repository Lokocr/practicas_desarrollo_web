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

        [HttpGet]
        public CuentaViewModel obtenerCuentas()
        {

            var _model = new CuentaViewModel();

            using(var context = new PracticaDbContext())
            {
                var listaCuentas = context.Datos.ToList();

                _model.listaCuentas = listaCuentas;
            }

            return _model;
        }

        [HttpPost]
        public IActionResult buscarCantones(ProvinciaModel provincia)
        {
            var model = new CantonesViewModel();

            if(ModelState.IsValid)
            {

                using (var context  = new PracticaDbContext())
                {
                    model.listaCantones = context.Canton
                                    .Where(a => a.provincia == Convert.ToInt32(provincia.codigoProvincia))
                                    .ToList();
                }

            }

            return Json(model);
        }


        [HttpPost]
        public IActionResult guardarCuenta(CuentaModel cuentaNueva)
        {

            if (ModelState.IsValid)
            {

                using (var context = new PracticaDbContext())
                {
                    context.Datos.Add(cuentaNueva);
                    context.SaveChanges();
                }

            }


            return Json("Datos Guardados");
        }

    }
}