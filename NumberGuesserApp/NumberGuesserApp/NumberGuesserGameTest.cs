using System;
namespace NumberGuesserGameApp
{
    internal class NumberGuesserGameTest
    {
        static int count = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO NUMBER GUESSING GAME! \nChoose A Number Between 1 To 100");
            Random rnd = new Random();
            int val = rnd.Next(0, 101);
            Game(val);
            Console.ReadKey();
        }
        static void Game(int val)
        {
            Console.Write("Guess the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == val)
            {
                Console.WriteLine("Congratulation! You Guessed Right Number \n");
                Console.WriteLine("Number Of Tries: "+count);
                Random rnd = new Random();
                int new_val = rnd.Next(0, 101);
                count = 0;
               PlayAgain(new_val);
            }
            else if (num > val)
            {
                Console.WriteLine("Sorry,Too High!!");
                PlayAgain(val);
            }
            else
            {
                Console.WriteLine("Sorry,Too Low!!");
                PlayAgain(val);
            }

        }
        static void PlayAgain(int com)
        {
            Console.Write("Press \na -> Play Again \ne -> Exit the game\nEnter to continue the game:");
            string ip = Console.ReadLine();
            if (ip == "a")
            {
                Random rnd = new Random();
                int val = rnd.Next(0, 101);
                count=0;
                Game(val);
            }
            else if (ip == "e")
            {
                Console.WriteLine("Numer of tries " + count);
                return;
            }
            else
            {   count++;
                Game(com);
            }

        }

    }
}