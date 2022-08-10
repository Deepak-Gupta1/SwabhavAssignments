using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateWithLambdaApp
{
    internal class Program
    {
        public delegate void Dmessage(string message);
        static void Main(string[] args)
        {
            Dmessage obj;
            obj = (name) => { Console.WriteLine("Say Hello " + name); };
            obj = (name) => { Console.WriteLine("Say GoodBye " + name); };
            obj("deepak");
            MessageWizard((n1) => { Console.WriteLine("howdy " + n1); }); 
            MessageWizard((n2) => { Console.WriteLine("Ola " + n2); }); 
            
            Console.ReadKey();
        }
        

        static void MessageWizard(Dmessage fn)
        { 
            Random rnd = new Random();
            var num=rnd.Next(10);
            Console.WriteLine(num);
            if (num > 5)
            {
                fn("Champ");
            }
        }
    }
}

