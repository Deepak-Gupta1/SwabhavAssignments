using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodApp.Extensions;
namespace ExtensionMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Monocept";
            Console.WriteLine(name.Foo());
            Console.ReadLine();
            args.ToList().ForEach(x => Console.WriteLine(x.Foo()));
        }
      
    }
}
