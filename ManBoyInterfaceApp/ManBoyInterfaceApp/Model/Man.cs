using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Model
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man depart");
        }

        public void Wish()
        {
            Console.WriteLine("Man Wish");
        }
    }
}
