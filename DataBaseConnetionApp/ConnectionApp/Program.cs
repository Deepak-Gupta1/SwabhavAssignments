using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                con = new SqlConnection(ConString);
                con.Open();
                Console.WriteLine("state of connetion " + con.State);
                Console.WriteLine("Server name is " + con.DataSource);
                Console.WriteLine("Datbase name is " + con.Database);
                Console.WriteLine("Time out " + con.ConnectionTimeout);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open) { con.Close(); }
                
            }
            Console.ReadKey();
        }
    }
}
