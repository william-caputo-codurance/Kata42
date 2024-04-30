namespace Kata42;

public class CalculatorService:ICalculatorService
{
    private readonly InMemoryRepository _repository;

    public CalculatorService(InMemoryRepository repository)
    {
        _repository = repository;
    }
    
    public ProductVm Calculate(int id)
    {
        var product = this._repository.GetById(id);

        var taxValue = GetTax(product);

        return new ProductVm()
        {
            ProductName = product.Name,
            CalculatedPrice = product.Price * (1 + taxValue),
            ShippingPrice = product.GetShippingPrice()
        };
    }

    private double GetTax(Product product)
    {
        double taxValue = 0.0;
        if (product.Category == "Eletronic Peripherals")
        {
            taxValue = 0.15;
        }else if (product.Category == "Computer")
        {
            taxValue = 0.35;
        }else if (product.Category == "License")
        {
            taxValue = 0.05;
        }

        return taxValue;
    }
}