using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Evaluacion
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal GetValue();

        public override string ToString()
        {
            return $"{Id} {Description}\n" +
                   $"       Price......:   ${Price:N2}\n" +
                   $"       Tax........:        {Tax:P2}\n" +
                   $"       Value......:   ${GetValue():N2}";
        }
    }

}
