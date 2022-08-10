using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    internal class Man
    {
        public void Walk()
        {
            Console.WriteLine("Man Walking");

        }
        public void Read()
        {
            Console.WriteLine("Man Reading");

        }
        public virtual void Play()
        {
            Console.WriteLine("Man Playing Chess");
        }
    }
}
