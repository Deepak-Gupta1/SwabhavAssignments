using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp.Model
{
    internal class DataService
    {
        private static DataService bucket;
        public DataService()
        {
            Console.WriteLine("Data Service created");
        }
        public static DataService CreateInstrance()
        {
            if(bucket == null)
            {
                bucket = new DataService();
            }
            return bucket;
        }
        public void DoSomething()
        {
            Console.WriteLine("Doing something "+this.GetHashCode());
        }
    }
}
