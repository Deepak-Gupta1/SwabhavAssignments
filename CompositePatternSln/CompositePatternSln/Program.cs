using CompositePatternSln.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder root = new Folder("Movie");
            root.AddChild(new File("abc.avi", 700));

            Folder comedy = new Folder("Comedy");
            comedy.AddChild(new File("lmo.avi", 800));

            Folder action = new Folder("Action");
            action.AddChild(new File("pqr.avi", 900));

            root.AddChild(comedy);
            root.AddChild(action);

            root.ShowDetails(2);

            Console.ReadKey();
        }
    }
}
