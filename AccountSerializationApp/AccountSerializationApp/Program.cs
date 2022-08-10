using AccountSerializationApp.Model;
using System;
using System.IO;
using System.Xml.Serialization;
namespace AccountSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            //CaseStudy3();
            Console.ReadKey();
        }
        public static void CaseStudy1() {
            Console.WriteLine("CaseStudy 1 Serialize");
            Account acc1 = new Account();
            acc1.Accno = 101;
            acc1.Name = "Deepak";
            acc1.Deposit(2000);
            acc1.Deposit(3000);
            XmlSerializer xs = new XmlSerializer(typeof(Account));
            Stream stream = new FileStream(@"XmlFile.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(stream, acc1);
            stream.Close();
            Console.WriteLine();
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("CaseStudy 2 Deserialize");
            XmlSerializer xs = new XmlSerializer(typeof(Account));
            Stream stream = new FileStream(@"XmlFile.xml", FileMode.Open, FileAccess.Read);
            Account objnew = (Account)xs.Deserialize(stream);
            Console.WriteLine("Accno " + objnew.Accno);
            Console.WriteLine("Name " + objnew.Name);
            Console.WriteLine("Balance " + objnew.Balance+"\n");
        }
    }
}
