using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareApp.Model
{
    internal class Square
    {
        public int l;
        public int CalculateArea()
        {
            return l*l;
        }
        public int CalculatePerimeter()
        {
            return 4* l;
        }
    }
}
