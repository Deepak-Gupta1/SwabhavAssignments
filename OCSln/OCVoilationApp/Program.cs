using OCVoilationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCVoilationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fixedDeposite = new FixedDeposite("Ajay", 200000, 3, FestivalType.Holi);
            Console.WriteLine(fixedDeposite);
            Console.ReadKey();
        }
    }
}
