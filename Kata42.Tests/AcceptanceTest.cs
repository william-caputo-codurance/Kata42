using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Kata42.Test;

public class AcceptanceTest
{
    private readonly HttpClient client;
    public AcceptanceTest()
    {
        var factory = new WebApplicationFactory<Program>();
        client = factory.CreateClient();
    }

    [Fact]
    public async Task ShouldBeRunning()
    {
        var result = await client.GetAsync("/health");
        var content = await result.Content.ReadAsStringAsync(); 
        content.Should().Be("Api is running");
    }

    [Fact]
    public async Task ShouldReturnTheCalculatedPrice()
    {
        var result = await client.GetAsync("/calculate/1"); 
        var content = await result.Content.ReadAsStringAsync(); 
        content.Should().Be("Produto Mouse sai por R$R$57,50");
    }
    
}