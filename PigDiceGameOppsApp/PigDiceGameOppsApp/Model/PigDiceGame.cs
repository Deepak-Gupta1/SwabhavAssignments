using System;
namespace PigDiceGameOppsApp.Model
{
    internal class PigDiceGame
    {
        private int _dieValue = 0;
        private int _turnScore;
        private int _totalScore = 0;
        private int turn = 0;
        public void Game()
        {
            while (_totalScore <= 20)
            {
                turn++;
                Console.WriteLine("\nTURN " + turn);
                _turnScore = 0;
                NewTurn();
                _totalScore += _turnScore;
                if (_totalScore >= 20)
                {
                    break;
                }
                Console.WriteLine("Total score is " + _totalScore);
            }
            Console.WriteLine("\nCongratulation !! You Win");
            Console.WriteLine("Total score of is " + _totalScore + "\nYou finished in {0} turns! ",turn);
            Console.WriteLine("\nGAME OVER");
        }
        private void NewTurn()
        {
            while (true)
            {
                Console.Write("What do you want, Roll or Hold ?(r/h): ");
                String userInput = Console.ReadLine();
                if (CheckRollorHold(userInput))
                {
                    break;
                }
            }
        }
        private bool CheckRollorHold(String userInput)
        {
            if (userInput == "r")
            {
                _dieValue = Roll();
                Console.WriteLine("Die: " + _dieValue);
                _turnScore += _dieValue;
            }
            if (userInput == "h")
            {
                Console.WriteLine("Score of this Turn is " + _turnScore);
                return true;

            }
            if (_dieValue == 1)
            {
                _turnScore = 0;
                Console.WriteLine("Score of this Turn is " + _turnScore);
                Console.WriteLine("Turn over.");
                return true;
            }
            return false;
        }
        private int Roll()
        {
            Random rnd = new Random();
            int val = rnd.Next(1, 7);
            return val;
        }
    }
}
