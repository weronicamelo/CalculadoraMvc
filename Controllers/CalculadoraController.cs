using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMvc.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Calcular()
    {
        return View();
    } 
    
    public IActionResult Resultado([FromForm] double n1, [FromForm] double n2, [FromForm] string tipoOperacao)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.TipoOperacao = tipoOperacao;
        
        switch(tipoOperacao)
        {
            case "soma":
                ViewBag.Titulo = $"Soma";
                ViewBag.Resultado = $"Soma = {n1 + n2}";
                break;
        
            case "subtracao": 
                ViewBag.Titulo = $"Subtração";
                ViewBag.Resultado = $"Subtração = {n1 - n2}";
                break;
            
            case "multiplicacao":
                ViewBag.Titulo = $"Multiplicação";
                ViewBag.Resultado = $"Multiplicação = {n1 * n2}";
                break;
            
            case "divisao":
                ViewBag.Titulo = $"Divisão";
                ViewBag.Resultado = $"Divisão = {n1 / n2}";
                break;

            default:
                ViewBag.Resultado = "Operação inválida!";
                break;
        }

        return View();
    }
}