using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLib.Product
{
    internal class Audi : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi start");
        }

        public void Stop()
        {
            Console.WriteLine("Audi stop");
        }
    }
}
