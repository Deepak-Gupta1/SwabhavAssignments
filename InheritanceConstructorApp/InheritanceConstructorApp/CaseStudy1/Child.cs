using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp.CaseStudy1
{
    internal class Child : Parent
    {
        public Child():base(){
            Console.WriteLine("Child Created");
        }
    }
}
