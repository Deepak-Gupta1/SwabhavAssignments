using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaceApp.Model
{
    internal class CustomerRepo:Icrudable
    {
        public void Update()
        {
            Console.WriteLine("Customer Upadete");
        }
        public void Delete()
        {
            Console.WriteLine("Customer Delete");
        }
         
    }
}
