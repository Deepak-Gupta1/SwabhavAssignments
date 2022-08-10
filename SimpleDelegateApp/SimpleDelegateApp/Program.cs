using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateApp
{
    internal class Program
    {
        public delegate void Dmessage(string message);
        static void Main(string[] args)
        {
            //Dmessage messgae=new Dmessage(SayHello);
            Dmessage obj = SayHello;
            obj("Deepak");
            obj=(m)=>Console.WriteLine(m);
            obj("ksnd");
            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);
            //obj = Foo;  // Error No Match delegate 
            Console.ReadKey();
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Hello syas " + name);
        }
        static void SayGoodBye(string name)
        {
            Console.WriteLine("GoodBye  " + name);
        }
        static void Foo() {
        }
        static void MessageWizard(Dmessage fn)
        {
            fn("CHAMP");
        }
    }
}
