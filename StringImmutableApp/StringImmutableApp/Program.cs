using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userName = "Deepak";
            Console.WriteLine(userName);
            Console.WriteLine("Hash code :"+userName.GetHashCode());

            userName= userName.ToUpper();
            Console.WriteLine(userName);
            Console.WriteLine("Hash code :" +userName.GetHashCode());

            userName = userName + " Monocept";
            Console.WriteLine(userName);
            Console.WriteLine("Hash code "+userName.GetHashCode());

            userName = userName + " Hyderbad";
            Console.WriteLine(userName);
            Console.WriteLine("Hash code :"+userName.GetHashCode());

            Console.ReadKey();
        }
    }
}
