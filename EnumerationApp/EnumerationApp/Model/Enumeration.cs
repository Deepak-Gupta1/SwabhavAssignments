using System;
namespace EnumerationApp.Model
{
    internal class Enumeration
    {
        // declaring enum
        public enum shapes
        {
            circle,
            square,
            Triangle,
            Rectangle
        }
        public void FindShape(shapes s1)
        {
            Console.WriteLine("Shape: "+s1  +" Value: "+(int)s1);
        }
    }
}
