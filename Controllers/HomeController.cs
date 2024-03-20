using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FogliettaA_5I_EventiEF.Models;
using FogliettaA_5I_EventiEF.Data;

namespace FogliettaA_5I_EventiEF.Controllers;


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

    [HttpGet]
    public IActionResult SignUp(){
        return View();
    }

    [HttpPost]
     public IActionResult Conferma(Membro p){
        return View(p);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
