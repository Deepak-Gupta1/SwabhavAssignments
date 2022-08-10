using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoobileLib.Product
{
    internal class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla Start");
        }
        public void Stop()
        {
            Console.WriteLine("Tesla Stop");
        }
    }
}
