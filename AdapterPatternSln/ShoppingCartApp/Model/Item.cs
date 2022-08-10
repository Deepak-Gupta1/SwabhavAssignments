using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    public interface Item
    {
        string ItemName();
        double ItemPrice();
    }
}
