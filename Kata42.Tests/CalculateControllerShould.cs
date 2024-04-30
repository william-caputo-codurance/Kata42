using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Kata42.Test;

public class CalculateControllerShould
{

    private Mock<ICalculatorService> service = new();
    
    [Theory]
    [InlineData(1,"Mouse","R$57,50")]
    [InlineData(2,"Teclado","R$69,00")]
    [InlineData(2,"Teclado","R$69,00")]
    public void ReturnTextWitheTheCalculatedPrice(int id, string product, string price)
    {
        service.Setup(s => s.Calculate(1)).Returns(
            new ProductVm { ProductName = "Mouse", CalculatedPrice = 57.50 }
        );
        service.Setup(s => s.Calculate(2)).Returns(
            new ProductVm { ProductName = "Teclado", CalculatedPrice = 69.00 }
        );
        var controller = new CalculateController(service.Object);
        
        var result = controller.Calculate(id);

        result.Should().Be($"Produto {product} sai por {price}");
    }

}

public interface ICalculatorService
{
    public ProductVm Calculate(int id);
}