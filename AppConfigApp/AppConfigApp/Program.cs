using AppConfigApp.Model;
using System;

namespace AppConfigApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppConfig ap = new AppConfig();
            PrintDetails(ap);
            Console.Read();
        }
        private static void PrintDetails(AppConfig ap)
        {
            Console.WriteLine("Conncetion 1 Details");
            Console.WriteLine(ap.getServer1());
            Console.WriteLine(ap.getDatabase1());
            Console.WriteLine("\nConncetion 2 Details");
            Console.WriteLine(ap.getServer2());
            Console.WriteLine(ap.getDatabase2());

        }
    }
}
