using System;
namespace ConstructorChainingApp.Model
{
    internal class ConstructorChaining
    {
        public ConstructorChaining()
        {
            Console.WriteLine("1");
        }
        public ConstructorChaining(int x) : this()
        {
            Console.WriteLine("2");
        }
        public ConstructorChaining(int x, int y) : this(10)
        {
            Console.WriteLine("3");
        }
    }
}
