using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    internal class Boy:Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy Playing Cricket");
        }

        public void Eat()
        {
            Console.WriteLine("Boy Eating");
        }
    }
}
