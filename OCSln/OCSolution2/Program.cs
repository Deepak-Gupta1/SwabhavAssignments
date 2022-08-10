using OCSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolution2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fixedDeposite = new FixedDeposite("Ajay", 200000, 3, NormalRate);
            //FixedDeposite fixedDeposite = new FixedDeposite("Ajay", 200000, 3, ()=>8.0);
            Console.WriteLine(fixedDeposite);
            Console.ReadKey();

        }
        static double NormalRate()
        {
            return 7.0;
        }
        static double NewYear()
        {
            return 8.0;
        }
    }
}
