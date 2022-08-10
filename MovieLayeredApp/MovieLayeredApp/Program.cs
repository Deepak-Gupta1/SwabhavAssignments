using System;
using MovieLayeredApp.Model;
using MovieLayeredApp.Service;

namespace MovieLayeredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int display = 1;
            const int addMovie = 2;
            const int clearAll = 3;
            const int count = 4;
            const int exit = 5;
            while (true)
            {
                MovieService service = new MovieService();
                Console.WriteLine("1.Display movies\n2.Add movie\n3.Clear all\n4.Get Count Of Movie Listed\n5.Exit");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case display:
                        Display(service);
                        break;
                    case addMovie:
                        AddMovie(service);
                        break;
                    case clearAll:
                        service.ClearAll();
                        break;
                    case count:
                        Console.WriteLine("Number Of Movies Listed "+service.GetCount());
                        break;
                    case exit:
                        return;
                    default:
                        break;
                }
            }
        }

        private static void Display(MovieService service)
        {
            Movie[] mv = service.Get();
            for (int i = 0; i < service.GetCount(); i++) 
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine(mv[i].Id + "|" + mv[i].Name + "|" + mv[i].Genre + "|" + mv[i].Year);
            }
            Console.WriteLine("-----------------------------\n");
        }
        private static void AddMovie(MovieService service)
        {
            if (service.GetCount() == 5)
            {
                Console.WriteLine("Movie store can add only 5 movie!!");
                return;
            }
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Year: ");
            string year = Console.ReadLine();
            Movie m = new Movie(service.GetCount() + 1, name, genre, year);
            service.Add(m);
        }
    }
}
