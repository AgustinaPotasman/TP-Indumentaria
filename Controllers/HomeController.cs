using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Indumentaria.Models;

namespace TP_Indumentaria.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.Equipos = Equipos.ListaEquipos;
        ViewBag.Medias = Equipos.ListaMedias;
        ViewBag.Pantalones = Equipos.ListaPantalones;
        ViewBag.Remeras = Equipos.ListaRemeras;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GuardarIndumentaria (int Equipo, int Media, int Pantalon, int Remera)
    {
        if(Equipo < 0 || Equipo > Equipos.ListaEquipos.count()-1 || Media < 0 || Media > Equipos.ListaMedias.count()-1 || Pantalon < 0 || Pantalones > Equipos.ListaPantalones.count()-1 ||Equipo < 0 || Remera > Equipos.ListaRemeras.count()-1 )
        {
            ViewBag.Error = "Debe seleccionar todos los campos";
            return View("SelectIndumentaria");
        }
        else
        {
            Indumentaria indumentaria = new Indumentaria();
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private class EquiposIndumentaria
    {
        internal static void Add(string equipo, string media, string pantalon, string remera)
        {
            throw new NotImplementedException();
        }
    }
}