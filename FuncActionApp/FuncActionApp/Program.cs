using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action -->point to funcyion which doesnt return a value
            Action<int> printEvenNosTill = (limit) =>
            {
                for (int i = 2; i <= limit; i += 2){Console.Write(i + " ");}
                Console.WriteLine("");
                return;
            };
            printEvenNosTill(20);

            //Func -->(functions) point to function with return type 
            Func<int, int[]> getEvenNosTill = (limit) =>
              {
                  int [] evens=new int [limit/2];
                  for (int i = 2, index = 0; i <=limit; i+=2){
                          evens[index] = i;
                          index += 1;
                      }
                  return evens;
              };
            foreach (int even in getEvenNosTill(30)) {
                Console.Write(even+" ");
            }
            Console.WriteLine();

            //Predicate-->point to Function with boolean return type and single parameter
            Predicate<int> isEvenNo = (n) =>n%2==0;
            Console.WriteLine(isEvenNo(19));

            Predicate<int> isOddno = (n) => n % 2 != 0;
            Console.WriteLine(isOddno(19));

            Console.ReadKey();
        }
    }
}
