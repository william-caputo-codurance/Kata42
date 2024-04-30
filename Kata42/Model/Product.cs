namespace Kata42;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
    public bool IsDigital { get; set; }
    public double? Weight { get; set; }
    
    private const double ShippingPrice = 3.5;

    public double GetShippingPrice()
    {
        return this.IsDigital? 0: this.Weight.Value * ShippingPrice;
    }
}