using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedQuerisApp
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
                Console.WriteLine("Enter a empno");
                string empno = Console.ReadLine();

                //To avoid SQL injection 
                //string querystring = "select * from emp where empno=" + empno;

                //use parameterized query
                string querystring = "select * from emp where empno=@EmpNo";

                // 1. declare command object with parameter
                SqlCommand cmd = new SqlCommand(querystring, con);
                
                // 2. define parameters used in command object
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@EmpNo";
                param.Value = empno;

                // 3. add new parameter to command object
                cmd.Parameters.Add(param);

                // get data stream
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
                }
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open) { con.Close(); }

            }
            Console.ReadKey();
        }
    }
}
