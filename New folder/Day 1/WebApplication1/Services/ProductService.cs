using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }
        public async Task<int> CheckoutProduct(string str)
        {
            var products = await _context.Product.ToListAsync();

            int result = calculate(products, str);
            return result;
        }

        public int calculate(List<Product> products, string str)
        {
            Dictionary<char, int> strCount = new Dictionary<char, int>();
            foreach (char ch in str)
            {
                if (strCount.ContainsKey(ch)) strCount[ch]++;
                else strCount[ch] = 1;
            }
            Dictionary<char, int> prices = new Dictionary<char, int>();
            Dictionary<char, (int frequencyTerm, int discountedPrice)> offers = new Dictionary<char, (int, int)>();
            foreach (Product product in products)
            {
                if (!prices.ContainsKey(product.Item)) prices[product.Item] = product.Price;
                else continue;

                if (product.Offer != null)
                {
                    int quantity = Convert.ToInt32(product.Offer.Split(" ")[0]);
                    int price = Convert.ToInt32(product.Offer.Split(" ")[2]);

                    if (!offers.ContainsKey(product.Item)) offers[product.Item] = (quantity, price);
                    else continue;
                }
            }

            int total = 0;
            int offerTotal = 0;
            int normalTotal = 0;


            foreach (KeyValuePair<char, int> pair in strCount)
            {

                Console.WriteLine(pair.Key + "------" + pair.Value);
                if (offers.ContainsKey(pair.Key))
                {
                    //frenquency Multiplier Calculation
                    var tuple = offers[pair.Key];
                    int frequencyTerm = tuple.frequencyTerm;
                    int discountedPrice = tuple.discountedPrice;


                    int nosOffer = pair.Value / frequencyTerm;
                    int remainderOffer = pair.Value % frequencyTerm;

                    offerTotal = nosOffer * discountedPrice;

                    if (remainderOffer > 0)
                    {
                        offerTotal += remainderOffer * prices[pair.Key];
                    }

                }
                else
                {
                    //Normal Calculation
                    normalTotal = pair.Value * prices[pair.Key];
                }

                Console.WriteLine(total);
                total += normalTotal + offerTotal;

            }


            return total;
        }

        public async Task DeleteProduct(char id)
        {
            var productDb = await GetProduct(id);

            _context.Product.Remove(productDb);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetProduct(char id)
        {
            return await _context.Product.FindAsync(id);
        }

        public async Task<Product> PostProduct(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public bool ProductExists(char id)
        {
            return (_context.Product?.Any(e => e.Item == id)).GetValueOrDefault();
        }

        public async Task<Product> PutProduct(char id, Product product)
        {
            var productDb = await GetProduct(id);

            productDb.Item = product.Item;
            productDb.Price = product.Price;
            productDb.Offer = product.Offer;

            await _context.SaveChangesAsync();
            return product;
        }
    }
}
