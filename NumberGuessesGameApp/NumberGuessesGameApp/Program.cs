using NumberGuessesGameApp.Model;
using System;

namespace NumberGuessesGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO NUMBER GUESSING GAME! \nChoose A Number Between 1 To 100");
            NumberGuessesGame GuessGame = new NumberGuessesGame();
            int new_val=GuessGame.RandNum();
            GuessGame.Game(new_val);
            Console.ReadKey();
        }

    }
}
