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
        ViewBag.Equipos = Equipos.ListaEquipos;
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

    public IActionResult GuardarIndumentaria (string Equipo, string Media, string Pantalon, string Remera)
    {
        if (Equipo != "")
        {
            if (Media != "")
            {
                if (Pantalon != "")
                {
                    if (Remera != "")
                    {
                        EquiposIndumentaria.Add(Equipo, Media, Pantalon, Remera);
                        return View(); 
                    }
                    else
                    {
                        ViewBag.MensajeDeError = "Error! Mal ingreso de datos";
                        return View(SelectIndumentaria());
                    }
                }
                else
                {
                    ViewBag.MensajeDeError = "Error! Mal ingreso de datos";
                    return View(SelectIndumentaria());
                }
            }
            else
            {
                ViewBag.MensajeDeError = "Error! Mal ingreso de datos";
                return View(SelectIndumentaria());
            }
        }
        else
        {
            ViewBag.MensajeDeError = "Error! Mal ingreso de datos";
            return View(SelectIndumentaria());
        }
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
