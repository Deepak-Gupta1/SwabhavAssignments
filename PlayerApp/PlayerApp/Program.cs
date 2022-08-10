using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();

            Console.Read();
        }

        private static void CaseStudy1()
        {
            Player sachin = new Player(101, "Sachin Tendulkar", 50);
            PrintDetails(sachin);


            Player virat = new Player(101, "Virat");
            PrintDetails(virat);


            Player elder = virat.WhoIsElder(sachin);
            PrintDetails(elder);

            Console.WriteLine(sachin.GetHashCode());
            Console.WriteLine(virat.GetHashCode());
            Console.WriteLine(elder.GetHashCode());
        }
        private static void CaseStudy2()
        {
            Player p1 = new Player(201, "MS Dhoni", 50);
            //Console.WriteLine(p1.InstanceCount);
            Console.WriteLine("Count "+Player.HeadCount);
            //PrintDetails(p1);

            Player p2 = new Player(202, "Rohit Sharma");
            //Console.WriteLine(p2.InstanceCount);
            Console.WriteLine("Count " + Player.HeadCount);
            //PrintDetails(p2);

            Player p3 = new Player(203, "Hardik Pandya");
            //Console.WriteLine(p2.InstanceCount);
            Console.WriteLine("Count " + Player.HeadCount);
            //PrintDetails(p3);

            Console.WriteLine(Player.HeadCount);
        }
        private static void CaseStudy3()
        {
            Player sachin = new Player(301, "Sachin Tendulkar", 50);
            PrintDetails(sachin);


            Player virat = new Player(302, "Virat");
            PrintDetails(virat);
        }

        private static void PrintDetails(Player p)
        {
            Console.WriteLine("ID " + p.Id);
            Console.WriteLine("Name "+p.Name);
            Console.WriteLine("Age " + p.Age);
            Console.WriteLine();
        }
    }
}
