using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class ShoppingCart
    {
         List<Item> Itemlist=new List<Item>();

        public void Add(Item item)
        {
            Itemlist.Add(item);
        }
        public void Remove(Item item)
        {
            if (Itemlist.Contains(item)) { Itemlist.Remove(item); }
        }
        public double TotalPrice()
        {
            double price=0;
            foreach (Item item in Itemlist)
            {
                price += item.ItemPrice();
            }

            return price;
        }
        public List<Item> Items
        {
            get { return Itemlist; }
        }
    }
}
