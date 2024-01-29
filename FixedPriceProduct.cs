using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Evaluacion
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValue()
        {
            return Price * (1 + (decimal)Tax);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
