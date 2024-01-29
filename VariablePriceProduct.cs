using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Evaluacion
{
    public class VariablePriceProduct : Product
    {
        public string? Measurement {  get; set; }
       public float Quantity { get; set; }

        public override decimal GetValue()
        {
            return Price * (decimal)Quantity * (1 + (decimal)Tax);
        }

       
        public override string ToString()
        {
            return base.ToString() +
                   $"\n       Measurement: {Measurement}\n" +
                   $"       Quantity...: {Quantity:F2}";
        }
    }
}
