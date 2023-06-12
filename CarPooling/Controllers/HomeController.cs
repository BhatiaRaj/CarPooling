using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarPooling.Models;
using CarPooling.Data;

namespace CarPooling.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CarpoolingDbContext carpoolingDb;

    public HomeController(ILogger<HomeController> logger,CarpoolingDbContext carpoolingDbContext)
    {
        _logger = logger;
        carpoolingDb = carpoolingDbContext;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MyRequest()
    {
        var CarPooling =  carpoolingDb.OppernigCarpooling.ToList();
        return View(CarPooling);
    }

   
    public IActionResult RequestView()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

