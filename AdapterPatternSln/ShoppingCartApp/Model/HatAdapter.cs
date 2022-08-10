using FancyLib.Hat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class HatAdapter:Item
    {
        Hat hat;
        public HatAdapter(Hat hat)
        {
            this.hat = hat;
        }

        public string ItemName()
        {
            return  "Short Name: "+hat.ShortName+" Long Name: "+hat.LongName ;
        }

        public double ItemPrice()
        {
            return hat.Price;
        }
    }

}
