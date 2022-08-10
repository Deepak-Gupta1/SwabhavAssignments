using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        string _borderColor = "RED";
        string _fillColor = "RED";

        public Rectangle() { }
        public Rectangle(int width , int height)
        {
            _width = width;
            _height = height;
        }

        public Rectangle(int width, int height,string fillColor, string borderColor )
        {
            _width = width;
            _height = height;
            _fillColor = fillColor;
            _borderColor = borderColor;
        }


        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public string BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = ValidColor(value);
            }
        }

        public string FillColor
        {
            get { return _fillColor; }
            set
            {
                _fillColor = ValidColor(value);

            }
        }
        public int Area
        {
            get { return _width * _height; }
        }

        private string ValidColor(string color)
        {
            string fixcolor = "";
            color = color.ToUpper();
            if (color.Equals("BLUE") || color.Equals("GREEN"))
            {
                fixcolor = color;
            }

            return fixcolor;
        }
    
    }
}

