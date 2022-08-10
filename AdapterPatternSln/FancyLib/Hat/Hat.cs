using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyLib.Hat
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _price;
        private double _gst ;

        public Hat(string shortN ,String longN,double price)
        {
            _shortName = shortN;
            _longName = longN;
            _price = price;
            _gst = 0.08;
        }
        public string ShortName { get { return _shortName; } }
        public string LongName { get { return _longName; } }
        public double Price { get { return _price-_price*_gst; } }


    }
}
