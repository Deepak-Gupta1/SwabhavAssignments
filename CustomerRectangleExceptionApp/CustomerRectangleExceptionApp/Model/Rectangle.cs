using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRectangleExceptionApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        string _borderColor = "RED";
        string _fillColor = "RED";

        public Rectangle(int width , int height ,string borderColor ,string fillColor)
        {
            ValidateDimension(width);
            ValidateDimension(height);
            ValidateColor(borderColor);
            ValidateColor(fillColor);
            _width = width;
            _height = height;
            _borderColor=borderColor;
            _fillColor = fillColor;
        }

        public int Width { get { return _width; } set { ValidateDimension(value); _width = value; } }
        public int Height { get { return _height; } set { ValidateDimension(value);  _height = value; } }
        public string Border { get { return _borderColor; } set { ValidateColor(value); _borderColor = value; } }
        public string FillColor { get { return _fillColor; } set { ValidateColor(value); _fillColor = value; } }

        private void ValidateDimension(int dimension)
        {
            if (dimension < 0 || dimension >100)
            {
                throw new InvalidRectangleDimensionException("Only 1 - 100 range is valid");
            }
        }
        private void ValidateColor(string color)
        {
            color = color.ToUpper();
            if (!(color.Equals("BLUE") || color.Equals("GREEN")))
            {
                throw new InvalidRectangleColorException("Only Red Blue Green colors are valid");
            }
        }
    }
}

