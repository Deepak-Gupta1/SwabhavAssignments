using System;

namespace RectangleEncapsulation.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        public void SetWidth(int width)
        {
            this._width = CheckValue(width);
        }
        public void SetHeight(int height)
        {
           this._height = CheckValue(height);
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeigh()
        {
            return _height;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        private int CheckValue(int val)
        {
            if (val > 100) { val = 100; }
            else if (val < 1) { val = 1; }
          
            return val;
        }

    } 
}
