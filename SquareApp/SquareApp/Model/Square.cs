using System;
namespace SquareApp.Model
{
    internal class Square
    {
        public int l;
        public string c;

        public int CalculateArea()
        {
            return l * l;
        }
        public int CalculatePerimeter()
        {
            return 4 * l;
        }
    }
}
