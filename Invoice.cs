using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Evaluacion
{
    public class Invoice
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public IEnumerable<Product> GetInvoiceItems()
        {
            return _products;
        }

        public decimal Total => _products.Sum(p => p.GetValue());
    }
}
