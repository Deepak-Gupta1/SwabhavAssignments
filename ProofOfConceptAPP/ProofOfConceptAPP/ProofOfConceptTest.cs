using System;
namespace ProofOfConceptAPP
{
    internal class ProofOfConceptTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nUse Of For Loop");
            for (int i = 1; i < 11; i++) { 
                  Console.WriteLine(i);
            }

            Console.WriteLine("\nUse Of For Each Loop");
            string[] name = { "Deepak", "Ajay", "Akash", "Raj" };
            foreach (string s in name) {
                 Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
