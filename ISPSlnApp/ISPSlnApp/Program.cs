using ISPSlnApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Robot r = new Robot();
            AtTheWorkstation(m);
            AtTheWorkstation(r);
            AtTheCafetteria(m);
            AtTheCafetteria(r);
            Console.ReadKey();
        }

        private static void AtTheWorkstation(IWorker worker)
        {
            Console.WriteLine("At the workstation");
            worker.StartWork();
            worker.StopWork();
        }
        private static void AtTheCafetteria(IWorker worker)
        {
            Console.WriteLine("At the Cafetterial");
            worker.StartEat();
            worker.StopEat();
        }
    }
}
