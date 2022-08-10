using AutoobileLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoobileLib.Factory
{
    internal class TeslaFactory : IAutoFactory
    {
        public IAutomobile make()
        {
            return new Tesla();
        }
    }
}
