using ReflectorApp.Model;
using System;
using System.Reflection;
namespace ReflectorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            //CaseStudy3();
            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            int num = 100;
            Type typeNum = num.GetType();
            Console.WriteLine(typeNum);

            Type strType = typeof(String);
            Console.WriteLine(strType.FullName);
            Console.WriteLine(strType.BaseType);
            Console.WriteLine(strType.IsClass);
            Console.WriteLine(strType.IsEnum);
            Console.WriteLine(strType.IsInterface);
        }

        private static void CaseStudy2()
        {
            Account acc = new Account(201, "Rudra");
            Type typeAcc = acc.GetType();
            ShowDetails(typeAcc);
        }
        private static void ShowDetails(Type t)
        {
            Console.WriteLine("Meta Type Of Class : " + t);
            MethodInfo[] methodArr = t.GetMethods();
            Console.WriteLine("Count Of Methods : " + methodArr.Length);
            foreach (MethodInfo mi in methodArr)
            {
                Console.WriteLine(mi.Name);

            }
            ConstructorInfo[] conArr = t.GetConstructors();
            Console.WriteLine("\nCount Of Constructor : " + conArr.Length);
            foreach (ConstructorInfo coni in conArr)
            {
                Console.WriteLine(coni);
            }
            PropertyInfo[] propArr = t.GetProperties();
            Console.WriteLine("\nCount Of Property : " + propArr.Length);
            foreach (PropertyInfo pi in propArr)
            {
                Console.WriteLine(pi.Name);
            }
        }
    }
}
