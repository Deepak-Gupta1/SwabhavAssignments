using System;

namespace NumberGuessesGameApp.Model
{
    internal class NumberGuessesGame
    {
        static int count = 1;
        public void Game(int val)
        {
            Console.Write("Guess the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == val)
            {
                Console.WriteLine("Congratulation! You Guessed Right Number \n");
                Console.WriteLine("Number Of Tries: " + count);
                int new_val = RandNum();
                count = 0;
                PlayAgain(new_val);
            }
            if (num > val)
            {
                Console.WriteLine("Sorry,Too High!!");
                PlayAgain(val);
            }
            Console.WriteLine("Sorry,Too Low!!");
            PlayAgain(val);
        }
        private void PlayAgain(int com)
        {
            Console.Write("Press \na -> Play Again \ne" +
                " -> Exit the game\nEnter to continue the game:");
            string ip = Console.ReadLine();
            if (ip == "a")
            {
                int val = RandNum();
                count = 0;
                Game(val);
            }
            if (ip == "e")
            {
                Console.WriteLine("Numer of tries " + count);
                return;
            }
            count++;
            Game(com);
        }
        public int RandNum()
        {
            Random rnd = new Random();
            int new_val = rnd.Next(0, 101);
            return new_val;

        }
    }
}
