using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp.Model
{
    internal class RealImage:IImage
    {
        private string _filename;
        public RealImage(string filename)
        {
            _filename = filename;
            Console.WriteLine("loading"+filename);
        }
        public void display()
        {
            Console.WriteLine("display"+_filename);
        }

    }
}
