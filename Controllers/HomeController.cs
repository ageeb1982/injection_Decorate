using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using injection_Decorate.Models;
using TamkenSoft.Modules.Common.ageebTools.test;

namespace injection_Decorate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,ITest itest)
    {
        _logger = logger;
        var msg=itest.GetMsg();
        Console.WriteLine(msg);
        
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
}
