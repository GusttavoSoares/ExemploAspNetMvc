using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class Number 
{
    public float Number1 { get; set; }
    public float Number2 { get; set; }
}

public class OperacoesMatematicas {

}

public class OperacoesMatematicasController : Controller
{
    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult ResultadoSoma([FromForm] Number number)
    {
        return View(number);
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult ResultadoSubtracao([FromForm] Number number)
    {
        return View(number);
    }

     public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult ResultadoMultiplicacao([FromForm] Number number)
    {
        return View(number);
    }

     public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult ResultadoDivisao([FromForm] Number number)
    {
        return View(number);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
