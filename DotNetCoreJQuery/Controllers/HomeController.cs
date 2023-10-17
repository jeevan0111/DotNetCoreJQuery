using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreJQuery.Models;

namespace DotNetCoreJQuery.Controllers;

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

    [HttpPost]
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    [HttpPost]
    public int Mul(int num1, int num2)
    {
        return num1 * num2;
    }

    [HttpPost]
    public CalculateModel CalculateNumber (int num1, int num2)
    {
        CalculateModel calculateModel = new CalculateModel();
        calculateModel.Add = num1 + num2;
        calculateModel.Multiply = num1 * num2;

        return calculateModel;
    }

}

