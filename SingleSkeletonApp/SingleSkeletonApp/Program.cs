using SingletonApp.Model;
using System;
using System.Threading;
namespace SingletonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            Thread t1 = new Thread(Execute);
            Thread t2 = new Thread(Execute);
            Thread t3 = new Thread(Execute);
            t1.Start();
            Thread.Sleep(200);
            t2.Start();
            Thread.Sleep(200);
            t3.Start();
            Console.ReadKey();
        }
        static void Execute()
        {
            var service = DataService.CreateInstrance() ;
            service.DoSomething();
        }

        private static void CaseStudy1()
        {
            var svc1 = DataService.CreateInstrance();
            var svc2 = DataService.CreateInstrance();
            Console.WriteLine(svc1.GetHashCode());
            Console.WriteLine(svc2.GetHashCode());
        }
    }
}







//This pattern involves a single class which is responsible to create an object
//while making sure that only single object gets created.
//This class provides a way to access its only object
// which can be accessed directly without need to instantiate the object of the class.