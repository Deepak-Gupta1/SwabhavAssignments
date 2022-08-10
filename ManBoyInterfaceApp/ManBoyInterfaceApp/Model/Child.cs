using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Model
{
    internal class Child : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Child Cry");
        }

        public void Laugh()
        {
            Console.WriteLine("Child Laugh");
        }

        public void Depart()
        {
            Console.WriteLine("Child depart");
        }

        public void Wish()
        {
            Console.WriteLine("Child Wish");
        }
    }
}
