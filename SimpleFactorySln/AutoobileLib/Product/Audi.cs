using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoobileLib.Product
{
    internal class Audi:IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Audi Start");
        }
        public void Stop()
        {
            Console.WriteLine("Audi Stop");
        }
    }
}
