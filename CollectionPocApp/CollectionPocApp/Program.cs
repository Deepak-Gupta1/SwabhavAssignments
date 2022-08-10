using CollectionPocApp.Model;
using System;
using System.Collections.Generic;
namespace CollectionPocApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
            Console.ReadKey();
        }

        private static void CaseStudy3()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            // Adding key/value pairs in myDict
            myDict.Add("1", "C");
            myDict.Add("2", "C++");
            myDict.Add("3", "Java");
            myDict.Add("4", "Python");
            myDict.Add("5", "C#");
            myDict.Add("6", "HTML");
            Console.WriteLine("Total key/value pairs" + " in myDict are : " + myDict.Count);
            Console.WriteLine("\nThe key/value pairs" + " in myDict are : ");
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            myDict.Remove("4");
            Console.WriteLine("After Removing key 4 ,Total key / value pairs in myDict are: " + myDict.Count);
            myDict.Clear();
            Console.WriteLine("After Deleting All key / value pairs in myDict , Total key/value pair is : " + myDict.Count);

        }

        private static void CaseStudy2()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("apple");
            set.Add("banana");
            set.Add("mango");
            set.Add("grapes");
            Console.WriteLine("Element in set");
            foreach (string item in set)
            {
                Console.WriteLine(item);
            }
            Console.Write("Number of Element in set: " + set.Count);
            set.Remove("mango");
            Console.WriteLine("\nAter Removing mango in set");
            Console.Write("Number of Element in set: " + set.Count);
            set.Clear();
            Console.WriteLine("\nAter Clearing All Elements in Set");
            Console.Write("Number of Element in Set: " + set.Count);
        }

        private static void CaseStudy1()
        {
            ListCollection myList = new ListCollection();
            myList.AddData(100);
            myList.AddData(900);
            myList.AddData(300);
            myList.AddData(400);
            Console.WriteLine("Element in list");
            myList.PrintList();
            Console.Write("Number of Element in list: ");
            myList.GetCount();
            myList.RemoveData(900);
            myList.RemoveAt(2);
            Console.WriteLine("\nAter Removing 900 and 2nd position Elements in list");
            Console.Write("Number of Element in list: ");
            myList.GetCount();
            myList.ClearList();
            Console.WriteLine("\nAter Clearing All Elements in list");
            Console.Write("Number of Element in list: ");
            myList.GetCount();
        }
    }    
}
