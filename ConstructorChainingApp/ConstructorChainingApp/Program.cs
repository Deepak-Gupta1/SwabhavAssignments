using ConstructorChainingApp.Model;
using System;
/* It’s used when we want to invoke one constructor from another constructor.
We need to use this keyword after our constructor’s definition.*/
namespace ConstructorChainingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorChaining c = new ConstructorChaining(10, 20);
            Console.Read();
        }
    }
}
