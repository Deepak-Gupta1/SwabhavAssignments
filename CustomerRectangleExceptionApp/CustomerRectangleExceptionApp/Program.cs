using CustomerRectangleExceptionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRectangleExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle r = new Rectangle(1,100,"Red","Green");
                PrintDetails(r);
                r.Height += 1;
                PrintDetails(r);
                r.Width -= 10;
                PrintDetails(r);
            }
            catch (InvalidRectangleDimensionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Main");
            }
            Console.ReadKey();
        }
        static void PrintDetails(Rectangle obj)
        {
            Console.WriteLine("Width: "+obj.Width);
            Console.WriteLine("Height: "+obj.Height);
            Console.WriteLine("Fill Color: "+obj.FillColor);
            Console.WriteLine("Border Color: " + obj.Border);
        }
    }
}
