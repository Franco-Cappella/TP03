using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult MostrarDatosAlbum(string nomAlbum)
    {
        if(Disquera.DicDiscos.ContainsKey(nomAlbum))
        {
            ViewBag.Disco = Disquera.DicDiscos[nomAlbum]; 
        }
        return View("MostrarDatosAlbum");
    }
    public IActionResult Index()
    {
        Disquera.InicializarDisquera();
        ViewBag.Discos = Disquera.DicDiscos;
        return View();
    }
}
