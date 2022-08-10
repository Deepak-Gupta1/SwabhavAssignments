using ManBoyInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Child y =new Child();
            AtThePartyHall(x);
            AtThePartyHall(y);
            AtTheMovieHall(x);
            AtTheMovieHall(y);
        }
        private static void AtThePartyHall(IMannerable obj)
        {
            Console.WriteLine("At The Part");
            obj.Wish();
            obj.Depart();
        }
        private static void AtTheMovieHall(IEmotionable obj)
        {
            Console.WriteLine("At The Part");
            obj.Cry();
            obj.Laugh();
        }
    }
}
