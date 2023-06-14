using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace TestProject1
{
    internal class FakeProductService : WebApplication1.Services.IProductService
    {
        public Task<int> CheckoutProduct(string str)
        {
            if(str == "AAA")
            {
                return Task.FromResult(150);
            }
            return Task.FromResult(0);
        }

        public Task DeleteProduct(char id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(char id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> PostProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool ProductExists(char id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> PutProduct(char id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
