using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Model
{
    internal class CalculateTax:ITaxAmount
    {
        public double CalculateTaxAmount(Product product)
        {
            return product.Amount * product.TaxPercent / 100;
        }
    }
}
