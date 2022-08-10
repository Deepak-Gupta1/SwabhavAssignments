using System;
namespace ValueDataTypeApp
{
    struct Books
    {
        public string bookName;
    };
    class Car
    {
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            string c1 = car1.name = "BMW";
            string c2 = car1.name = "BMW";
            Console.WriteLine(c1==c2);

            Car car2 = new Car();
            car2.name = "Ferrari";
            Console.WriteLine(car1==car2);

            Books book1 = new Books();
            string b1 = book1.bookName = "Rich Dad Poor Dad";
            string b2 = book1.bookName = "A Brief History of Time";
            Console.WriteLine(b1 == b2);
            Console.ReadKey();

        }
    }
}
