using AutoMobileLayerLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLayerLib.Factory
{
    public class AutoMobileFactory
    {
        public IAutoMobile Make(AutoType autoType)
        {
            if(autoType == AutoType.Audi)
            {
                return new Audi();
            }
            if(autoType == AutoType.Tesla)
            {
                return new Tesla();
            }
            if (autoType == AutoType.BMW)
            {
                return new BMW();
            }
            return null;
        }
    }
}
