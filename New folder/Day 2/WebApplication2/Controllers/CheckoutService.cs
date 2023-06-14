using WebApplication2.Models;



namespace WebApplication2.Controllers
{
    public class CheckoutService
    {
        private readonly List<Item> items;

        public CheckoutService()
        {
            items = new List<Item>
            {
                new Item { Products = 'A', Amount = 70, Discount_Amount = new SpecialOffer { Quantity = 3, Discount_Price = 150 } },
                new Item { Products = 'B', Amount = 50, Discount_Amount = new SpecialOffer { Quantity = 2, Discount_Price = 85 } },
                new Item { Products = 'C', Amount = 20 },
                new Item { Products = 'D', Amount = 30 }
            };
        }

        public decimal CalculateTotalAmount(string products)
        {
            var itemCounts = GetItemCounts(products);

            decimal totalAmount = 0;

            foreach (var item in itemCounts)
            {
                var selectedItem = items.FirstOrDefault(i => i.Products == item.Key);
                if (selectedItem != null)
                {
                    totalAmount += CalculateItemAmount(selectedItem, item.Value);
                }
            }

            return totalAmount;
        }

        private Dictionary<char, int> GetItemCounts(string products)
        {
            var itemCounts = new Dictionary<char, int>();

            foreach (char product in products)
            {
                if (!itemCounts.ContainsKey(product))
                {
                    itemCounts[product] = 1;
                }
                else
                {
                    itemCounts[product]++;
                }
            }

            return itemCounts;
        }

        private decimal CalculateItemAmount(Item item, int quantity)
        {
            decimal totalAmount = 0;

            if (item.Discount_Amount != null)
            {
                int discountQuantity = item.Discount_Amount.Quantity;
                int regularQuantity = quantity % discountQuantity;
                int discountAmountQuantity = quantity / discountQuantity;

                totalAmount += discountAmountQuantity * item.Discount_Amount.Discount_Price;
                totalAmount += regularQuantity * item.Amount;
            }
            else
            {
                totalAmount = quantity * item.Amount;
            }

            return totalAmount;
        }
    }
}