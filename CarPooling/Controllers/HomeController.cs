using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarPooling.Models;

namespace CarPooling.Controllers;

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

    public IActionResult MyRequest()
    {
        return View();
    }

    //public IActionResult OfferingCarpooling()
    //{
    //    return View();
    //}

    //public IActionResult ApplyRequest()
    //{
    //    return View();
    //}

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

