using System;
using MovieLayeredV2App.Model;
using MovieLayeredV2App.Service;
namespace MovieLayeredV2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int display = 1;
            const int addMovie = 2;
            const int clearAll = 3;
            const int count = 4;
            const int search = 5;
            const int exportCsv = 6;
            const int exit = 7;
            
            while (true)
            {
                MovieService service = new MovieService();
                Console.WriteLine("1.Display movies\n2.Add movie\n3.Clear all\n4.Get Count Of Movie Listed\n5.Search\n6.Export Store Movie file\n7.Exit");
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
                        Console.WriteLine("Number Of Movies Listed " + service.GetCount());
                        break;
                    case search:
                        Console.Write("Search Movie : ");
                        string movieName = Console.ReadLine().ToUpper();
                        service.Search(movieName);
                        break;
                    case exportCsv:
                        service.ExportStoreMovieFile();
                        Console.WriteLine("File Export Successfully !!");
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
            if (service.GetCount() == service.Get().Length)
            {
                Console.WriteLine("Movie store can add only {0} movie!!", service.Get().Length);
                return;
            }
            Console.WriteLine("Name: ");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("genre: ");
            string genre = Console.ReadLine().ToUpper();
            Console.WriteLine("Year: ");
            string year = Console.ReadLine();
            Movie m = new Movie(service.GetCount() + 1, name, genre, year);
            service.Add(m);
        }
    }
}
