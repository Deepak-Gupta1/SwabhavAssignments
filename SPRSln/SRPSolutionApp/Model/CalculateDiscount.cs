using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Model
{
    internal class CalculateDiscount:IDiscount
    {
       
        public double CalculateDiscountAmount(Product product)
        {
            return product.Amount * product.DiscountPercent / 100;
        }
    }
}
