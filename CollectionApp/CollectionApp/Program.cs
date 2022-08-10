using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CollectionApp.Model;
namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            Type type = typeof(LineItem);
            MethodInfo [] me=type.GetMethods();
            foreach (MethodInfo mi in me)
            {
                Console.WriteLine(mi.Name);
            }

            Console.ReadKey();
        }

        private static void CaseStudy3()
        {
            HashSet<int> marks = new HashSet<int>();
            marks.Add(1);
            marks.Add(2);
            Console.WriteLine(marks.Count);

            HashSet<LineItem> items = new HashSet<LineItem>();
            items.Add(new LineItem(102, "Fastrack Watch", 2, 2000));
            items.Add(new LineItem(103, "books", 4, 2000));
            Console.WriteLine(items.Count); 
        }

        private static void CaseStudy2()
        {
            Console.WriteLine("Case Study 2");
            LinkedList<LineItem> basket = new LinkedList<LineItem>();
            basket.AddLast(new LineItem(101, "iphone", 2, 160000));
            basket.AddLast(new LineItem(102, "Fastrack Watch", 2, 2000));
            double productCost = 0;
            foreach (LineItem item in basket)
            {
                productCost += item.calcuateItem();
            }
            Console.WriteLine("The cost of Order " + productCost);
        }

        private static void CaseStudy1()
        {
            Console.WriteLine("Case Study 1");
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem(101, "iphone", 2, 160000));
            basket.Add(new LineItem(102, "Fastrack Watch", 2, 2000));
            basket.Add("Deepak");

            double productCost = 0;
            foreach (Object item in basket)
            {
                if (item is LineItem)
                {
                    productCost += CalculateCost((LineItem)item);
                }

            }
            Console.WriteLine("The cost of Order " + productCost);
        }

        private static double CalculateCost(LineItem item)
        {
           return item.calcuateItem();
        }
    }
}
