using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoobileLib.Product
{
    internal class BMW:IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("BMW Start");
        }
        public void Stop()
        {
            Console.WriteLine("BMW Stop");
        }
    }
}
