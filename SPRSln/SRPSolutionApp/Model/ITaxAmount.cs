using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    public interface ITaxAmount
    {
        double CalculateTaxAmount(Product product);
    }
}
