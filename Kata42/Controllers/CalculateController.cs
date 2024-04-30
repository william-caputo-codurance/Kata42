using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace Kata42;

[ApiController]
[Route("calculator")]
public class CalculateController:ControllerBase
{
    private readonly ICalculatorService _service;

    public CalculateController(ICalculatorService service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Route("/{id}")]
    public string Calculate(int id)
    {
        var calculated = _service.Calculate(id);
        return $"Produto {calculated.ProductName} sai por R${calculated.CalculatedPrice.ToString("0.00",CultureInfo.CurrentUICulture)} + R${calculated.ShippingPrice.ToString("0.00",CultureInfo.CurrentUICulture)} de frete";
    }
}