using SquareApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareApp
{
    internal class SquareTest
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            int[] SquareArray = new int[5];
            for (int i = 0; i < SquareArray.Length; i++)
            {
                Console.Write("Enter length of Square: ");
                int leng=Convert.ToInt32(Console.ReadLine());
                sq.l = leng;
                Console.WriteLine("Perimeter of this Square is : "+ sq.CalculatePerimeter());
                SquareArray[i] = sq.CalculateArea(); ;
            }
            Console.WriteLine("\nOut of all squres ,Maximum Area of Square is :"+SquareArray.Max());
            
            Console.ReadKey();
        }
    }
}
