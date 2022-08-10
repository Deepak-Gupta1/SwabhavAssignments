using DiamondProblemApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AndroidPhone sp = new AndroidPhone();
            sp.Call();
            sp.Camera();
            sp.Music();
            sp.Video();
            sp.Game();
            Console.ReadKey();
        }
    }
}
