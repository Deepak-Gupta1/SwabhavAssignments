using SimpleMoviesApp.Model;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace SimpleMoviesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            return;

            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            Movies[] MoviArr = new Movies[5];
            MoviArr[0] = new Movies(1, "Pushpa", "Action", "2022");
            MoviArr[1] = new Movies(2, "K.G.F: Chapter 2 ", "Action", "2022");
            MoviArr[2] = new Movies(3, "RRR", "Drama", "2022");
            MoviArr[3] = new Movies(4, "Prithviraj ", "History", "2022");
            MoviArr[4] = new Movies(5, "Bhool Bhulaiyaa", "Horror", "2019");

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Movies.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MoviArr);
            stream.Close();

            Stream stream1 = new FileStream("Movies.txt", FileMode.Open, FileAccess.Read);
            Movies[] mv = (Movies[])formatter.Deserialize(stream1) ;
            Console.WriteLine("size of Array " + mv.Length);
            for (int i = 0; i < mv.Length; i++)
            {
                Console.WriteLine(mv[i].Id + " " + mv[i].Name + " " + mv[i].Genre + " " + mv[i].Year);

            }
            stream.Close();
        }

        private static void CaseStudy2()
        {
            while (true)
            {
                Console.WriteLine("1.Display movies\n2.Add movies\n3.Clear all\n4.Exit");
                var op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Display();
                        break;
                    case "2":
                        Addmovie();
                        break;
                    case "3":
                        ClearAll();
                        break;
                    case "4":
                        return;
                    default:
                        break;
                }
            }
        }

        private static void Addmovie()
        {
            Movies[] MoviArr = new Movies[5];
            Console.WriteLine("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Year: ");
            string year = Console.ReadLine();
            
            string filePath = "AddMovies.txt";
            if (File.Exists(filePath))
            {
                Stream stream = new FileStream("AddMovies.txt", FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                if (stream.Length == 0)
                {
                    stream.Close();
                    MoviArr[0] = new Movies(id, name, genre, year);
                    stream = new FileStream("AddMovies.txt", FileMode.Open, FileAccess.Write);
                    formatter.Serialize(stream, MoviArr);
                    stream.Close();
                    return;

                }
                Movies[] mv = (Movies[])formatter.Deserialize(stream);
                for (int i = 0; i <mv.Length; i++)
                {
                    if (mv[i] == null)
                    {
                        stream.Close();
                        mv[i] = new Movies(id, name, genre, year);
                        stream = new FileStream("AddMovies.txt", FileMode.Open, FileAccess.Write);

                        formatter.Serialize(stream, mv);
                        stream.Close();

                        break;
                    }

                }
                stream.Close();
                
                Console.WriteLine("You Added movie");
                
            }
            else
            {
                Stream stream = new FileStream("AddMovies.txt", FileMode.Create, FileAccess.Write);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, MoviArr);
                stream.Close();
            }
           

        }

        private static void Display()
        {
            IFormatter formatter = new BinaryFormatter();
            string filePath = "AddMovies.txt";
            if (File.Exists(filePath))
            {
                Stream stream = new FileStream("AddMovies.txt", FileMode.Open, FileAccess.Read);
                Movies[] mv = (Movies[])formatter.Deserialize(stream);
                for (int i = 0; i < mv.Length; i++)
                {
                   
                    if (stream.Length==0)
                    {
                        Console.WriteLine("NO MOVIES ADDED");
                        return;

                    }
                    if (mv[i] == null)
                    {
                        return;
                    }
                    Console.WriteLine(mv[i].Id+"\n"+mv[i].Name+"\n"+mv[i].Genre+"\n"+mv[i].Year);
                }
                stream.Close();
            }
            else
            {
                Console.WriteLine("NO MOVIES ADDED");
            }
        
        }

        private static void ClearAll()
        {
            string str = "";
            File.WriteAllText("AddMovies.txt", str);
            
        }

    }
}
