using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLayerLib.Product
{
    internal class BMW : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BWM start");
        }

        public void Stop()
        {
            Console.WriteLine("BMW stop");
        }
    }
}
