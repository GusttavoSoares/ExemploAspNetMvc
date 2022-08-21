using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;


public class OperacaoMatematica 
{
    public float Number1 { get; set; }
    public float Number2 { get; set; }
    public string Operacao { get; set; }
}


public class CalculadoraController : Controller
{
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }


    public IActionResult Operacao()
    {
        return View();
    }

    public IActionResult Resultado([FromForm] OperacaoMatematica operacaoMatematica)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
