namespace Kata42;

public class InMemoryRepository
{
    private IList<Product> products = new List<Product>
    {
        new Product()
        {
            Id = 1, Name = "Keyboard", Price = 15.5, Category = "Eletronic Peripherals", IsDigital = false, Weight = 1.5
        },
        new Product()
        {
            Id = 2, Name = "Mouse", Price = 8, Category = "Eletronic Peripherals", IsDigital = false, Weight = 0.6
        },
        new Product()
        {
            Id = 3, Name = "Monitor", Price = 200, Category = "Eletronic Peripherals", IsDigital = false, Weight = 4.5
        },
        new Product()
        {
            Id = 4, Name = "Laptop Dell", Price = 800, Category = "Computer", IsDigital = false, Weight = 3
        },
        new Product()
        {
            Id = 5, Name = "Windows License", Price = 100, Category = "License", IsDigital = true, Weight = null
        },
    };

    public Product GetById(int id) => this.products.Where(s => s.Id == id).FirstOrDefault();
}