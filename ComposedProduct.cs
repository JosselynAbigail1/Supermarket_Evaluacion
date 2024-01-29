using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Evaluacion
{
    public class ComposedProduct:Product
    {
        public List<Product> Products { get; set; }
        public float Discount { get; set; }

        public ComposedProduct()
        {
            Products = new List<Product>();
        }

        public override decimal GetValue()
        {
            decimal totalValue = Products.Sum(p => p.GetValue());
            return totalValue * (1 - (decimal)Discount);
        }

        public override string ToString()
        {
            string productInfo = base.ToString();
            productInfo += $"\n       Discount...:   {Discount:P2}";

            if (Products.Any())
            {
                productInfo += "\n---------------------------- RECEIPT------------------------------------\n";
            }
            foreach (var product in Products)
            {
                productInfo += $"         {product.ToString()}\n";
            }
            decimal totalValue = GetValue();

            string productList = string.Join(", ", Products.Select(p => p.Description));
            productInfo += $"a. Products...: {productList}\n";
            productInfo += $"b. Discount...:        {Discount:P2}\n";

            decimal totalSum = GetValue() * (1 - (decimal)Discount);
            productInfo += $"c. Value:        ${totalValue:N2}\n";
            productInfo += $"TOTAL:               ${totalSum:N2}\n";

            return productInfo;
        }
    }

}
