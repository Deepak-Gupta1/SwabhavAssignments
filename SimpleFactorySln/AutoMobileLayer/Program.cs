using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMobileLayerLib.Factory;
using AutoMobileLayerLib.Product;

namespace AutoMobileLayer
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            AutoMobileFactory factory = new AutoMobileFactory();
            IAutoMobile auto =factory.Make(AutoType.Tesla);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());
            Console.ReadKey();
        }
    }

}
