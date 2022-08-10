using FileReadWriteApp.Model;
using System;
using System.IO;
namespace FileReadWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            FileReadWrite file = new FileReadWrite();
            //CaseStudy1(file);
            //CaseStudy2(file);
            CaseStudy3();
            Console.ReadKey();
        }
        private static void CaseStudy1(FileReadWrite file)
        {
            file.ReadTextFile();
            file.ReadHtmlFile();
            file.ReadXmlFile();
        }
        private static void CaseStudy2(FileReadWrite file)
        {
            file.WriteTextFile();
            file.WriteHtmlFile();
            file.WriteXmlFile();
        }
        private static void CaseStudy3()
        {
            string path = "C:\\Users\\Deepak\\source\\repos\\TextFile2.txt";
            Console.WriteLine("Username ");
            string text = Console.ReadLine();
            File.AppendAllText(path, text);
        }
    }
}
