using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class CadastroController : Controller
{
    private readonly ILogger<CadastroController> _logger;

    public CadastroController(ILogger<CadastroController> logger)
    {
        _logger = logger;
    }

    public IActionResult Formulario()
    {
        return View();
    }

    public IActionResult ResultadoFormulario([FromForm] User user)
    {
        return View(user);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
