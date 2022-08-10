using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();

            Console.ReadKey();
        }

        private static void CaseStudy4()
        {
            Customer deepak = new Customer(401, "Deepak");
            Order or1 = new Order(201, DateTime.Now);
            or1.Additem(new LineItem(301, new Product(101, "Realme", 10000, 10), 2));
            or1.Additem(new LineItem(302, new Product(102, "Hp Laptop", 30000, 15), 1));
            or1.Additem(new LineItem(303, new Product(103, "Boat Buds", 3000, 10), 1));
            deepak.AddOrder(or1);
            Customer rajkumar = new Customer(402, "Rajkumar");
            Order or2 = new Order(202, DateTime.Now);
            or2.Additem(new LineItem(304, new Product(104, "T-shirt", 3000, 10), 4));
            or2.Additem(new LineItem(305, new Product(105, "Watch", 2000, 15), 1));
            rajkumar.AddOrder(or2);
            Order or3 = new Order(203, DateTime.Now);
            or3.Additem(new LineItem(308, new Product(108, "Jeans", 3000, 15), 3));
            or3.Additem(new LineItem(309, new Product(109, "Keyboard", 5000, 10), 1));
            rajkumar.AddOrder(or3);
            PrintDetails(rajkumar);
        }
        private static void CaseStudy5()
        {
            Customer deepak = new Customer(402, "Deepak");
            Order or2 = new Order(202, DateTime.Now);
            or2.Additem(new LineItem(304, new Product(104, "T-shirt", 3000, 10), 4));
            or2.Additem(new LineItem(307, new Product(104, "T-shirt", 3000, 10), 1));
            deepak.AddOrder(or2);
            Order or3 = new Order(203, DateTime.Now);
            or3.Additem(new LineItem(308, new Product(108, "Jeans", 3000, 15), 3));
            or3.Additem(new LineItem(309, new Product(109, "Keyboard", 5000, 10), 1));
            deepak.AddOrder(or3);
            PrintDetails(deepak);
        }
        private static void PrintDetails(Customer obj)
        {
            Console.WriteLine("Order Invoice");
            Console.WriteLine("Customer Id " + obj.Id);
            Console.WriteLine("Name " + obj.Name);
            List<Order> items = obj.OrderList;
            Console.WriteLine("{0} Order Placed", items.Count);
            double checkOutPrice = 0;
            foreach (Order currentOrder in items)
            {
                Console.WriteLine("Order ID: " + currentOrder.Id);
                Console.WriteLine("Order Date: " + currentOrder.Date);
                foreach (LineItem lineItem in currentOrder.OrderItems)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Id " + lineItem.Id);
                    Console.WriteLine("Name " + lineItem.Product.Name);
                    Console.WriteLine("Price " + lineItem.Product.Price + " Rs" + " Quantity " + lineItem.Quantity);
                    Console.WriteLine("Discount " + lineItem.Product.DiscountPer+"%");
                    Console.WriteLine("Item Cost " + lineItem.CalculateItemCost() + " Rs");
                    Console.WriteLine("--------------------------");
                }
                checkOutPrice += currentOrder.CalculateCheckOutPrice();
            }
            Console.WriteLine(" Check out price " +checkOutPrice+ " Rs");

        }
        private static void CaseStudy3()
        {
            Order or = new Order(202, DateTime.Now);
            or.Additem(new LineItem(202, new Product(101, "Realme", 10000, 10), 2));
            or.Additem(new LineItem(203, new Product(102, "Hp Laptop", 30000, 15), 1));
            or.Additem(new LineItem(204, new Product(103, "Boat Buds", 3000, 10), 1));
            Console.WriteLine("Order ID: " + or.Id);
            Console.WriteLine("Order Date: " +or.Date);
            Console.WriteLine("  Products");
            foreach (LineItem lineItem in or.OrderItems)
            {
                Console.WriteLine("Product Id " + lineItem.Id);
                Console.WriteLine("Name " + lineItem.Product.Name);
                Console.WriteLine("Quantity " + lineItem.Quantity);
            }
            Console.WriteLine(" CheckoutPrice " + or.CalculateCheckOutPrice());
        }
        private static void CaseStudy2()
        {
            LineItem lineItem = new LineItem(202, new Product(101, "Iplus", 10000, 10), 2);
            Console.WriteLine("Item Id: " + lineItem.Id); ;
            Console.WriteLine("Product Id: " + lineItem.Product.Id + "\nName: " + lineItem.Product.Name + "\nPrice:" + lineItem.Product.Price + "" +
               " Rs Discount " + lineItem.Product.DiscountPer + "%" + "  Qunatity" + lineItem.Quantity+ "\nFinal Price " + lineItem.Product.calculateItemFinalPrice() + " Rs");
            Console.WriteLine(" Cost Of Product " + lineItem.CalculateItemCost());
        }
        private static void CaseStudy1()
        {
            Product p = new Product(101, "Realme phone", 10000, 10);
            Console.WriteLine("ID: "+p.Id + "\nName: " + p.Name + "\nPrice:"+ p.Price + "" +
                " Rs Discount "+p.DiscountPer+"%"+ "\nFinal Price " + p.calculateItemFinalPrice()+" Rs");

        }

    }
    
}
