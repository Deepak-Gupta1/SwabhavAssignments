using PigDiceGameOppsApp.Model;
using System;

namespace PigDiceGameOppsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PigDiceGame pigdice = new PigDiceGame();
            Console.WriteLine("Welcome to PIG DICE GAME !!\nGame Rules :" +
                "\nIn Each turn player can roll and hold dice." +
                "\nTurn ends when you hold or roll a 1." +
                "\nIf you roll a 1, you lose all points for the turn." +
                "\nIf you hold, you save all points for the turn." +
                "\nTo win game player have to score 20 points.");
            pigdice.Game();
            Console.ReadKey();
        }
    }
}
