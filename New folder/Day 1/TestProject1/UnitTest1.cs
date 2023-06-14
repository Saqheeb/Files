using WebApplication1.Controllers;
using Moq;
using WebApplication1.Services;
using TestProject1;

namespace WebApplication1;

public class UnitTest1
{
    private readonly FakeProductService _productRepo;
    private readonly ProductController _controller;
    public UnitTest1()
    {
        _productRepo = new FakeProductService();
        _controller = new ProductController(_productRepo);
    }

    [Fact]
    public async void ProductControllerTests_ShouldReturnCorrectNumber()
    { 
        int ExpectedResult = 150;

        int result = await _controller.CheckoutProduct("AAA");

        Assert.Equal(ExpectedResult, result);
    }
}