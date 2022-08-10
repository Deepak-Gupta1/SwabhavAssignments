using System;
namespace PassingParameterApp
{
    internal class Parameter
    {
        static void Main(string[] args)
        {
            int score = 100;
            UpdateScoreToZero(score);
            Console.WriteLine("After calling updateScore:" +score);
            int[] scores = { 80, 70, 67 };
            Console.WriteLine("Address of scores :"+scores.GetHashCode());
            UpdateAllScoresToZero(scores);
            foreach (int s in scores)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }

        static void UpdateScoreToZero(int pscore) {
            pscore = 0;
        }

        static void UpdateAllScoresToZero(int[] pscores) {
            Console.WriteLine("Address of pscores :"+pscores.GetHashCode());
            for (int i = 0; i < pscores.Length; i++) { 
                pscores[i] = 0;
            }
        
        }
    }
}
