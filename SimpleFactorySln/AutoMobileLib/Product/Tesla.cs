using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLib.Product
{
    internal class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla start");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla stop");
        }
    }
}
