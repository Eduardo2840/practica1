using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica1.Models;

namespace practica1.Controllers;

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

    public IActionResult Cambio(decimal cantidadEnvias)
{
    decimal tipoCambio = 1.5751M; 
    decimal cantidadRecibe = cantidadEnvias * tipoCambio;
    ViewBag.CantidadRecibe = cantidadRecibe;
    return View("conversion");
}

public IActionResult GenerarBoleta(string nombre, string dni, string apellido,string correo, decimal monto)
{
    ViewBag.Nombre = nombre;
    ViewBag. Apellido = apellido;
    ViewBag. Correo = correo;
    ViewBag.DNI = dni;
    ViewBag.Monto = monto;
    return View("Boleta");
}

}
