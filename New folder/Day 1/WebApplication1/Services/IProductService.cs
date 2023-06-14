using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProduct();

        Task<int> CheckoutProduct(string str);

        Task<Product> GetProduct(char id);

        Task<Product> PutProduct(char id, Product product);

        Task<Product> PostProduct(Product product);

        Task DeleteProduct(char id);

        bool ProductExists(char id);
    }
}
