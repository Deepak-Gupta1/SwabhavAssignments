using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp.Model
{
    internal class ProxyImage :IImage
    {
        private string _filename;
        private RealImage _realImage;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }
        public void display()
        {    if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.display();

        }
    }
}
