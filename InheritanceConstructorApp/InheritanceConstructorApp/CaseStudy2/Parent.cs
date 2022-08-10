using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp.CaseStudy2
{
    internal class Parent
    {
        private int _foo;
        public Parent(int foo)
        {
          _foo = foo;
        }
        public int Foo { get { return _foo; } }
    }
}
