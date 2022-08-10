using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolutionApp.Model
{
    internal class NormalRate : IFestivalRate
    {
        public double CalculateRate()
        {
            return 7.0;
        }
    }
}
