using ShoppingCartApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyLib.Hat;
namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new HatAdapter(new Hat("NGH","Nice Golden Hat",999)));
            PrintDetails(cart);
            Console.ReadKey();
        }

        static void PrintDetails(ShoppingCart c)
        {
            foreach (var item in c.Items)
            {
                Console.WriteLine("Name "+item.ItemName());
                Console.WriteLine("Price "+item.ItemPrice());
            }
            Console.WriteLine("Total Price "+c.TotalPrice());
        }
    }
}
