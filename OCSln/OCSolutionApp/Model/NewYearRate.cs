using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolutionApp.Model
{
    internal class NewYearRate : IFestivalRate
    {
        public double CalculateRate()
        {
            return 8.0;
        }
    }
}
