using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdotNetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteData();
            ShowDetails();
            //InsertData();
            Console.ReadKey();
        }

        private static void ShowDetails()
        {
            SqlConnection con=null;
            try
            {
                string ConString = @"Data Source=DESKTOP-4K86B5U;Initial Catalog=Swabhav;User ID=sa;Password=root";
                con = new SqlConnection(ConString);
                string querystring = "select * from emp";
                con.Open();
                SqlCommand cmd = new SqlCommand(querystring, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong..." + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private static void InsertData()
        {
            SqlConnection con = null;
            try
            {
                string ConString = @"Data Source=DESKTOP-4K86B5U;Initial Catalog=Swabhav;User ID=sa;Password=root";
                con = new SqlConnection(ConString);
                string querystring = "INSERT INTO EMP VALUES (1001,'Deepak','Devloper',7698,'22-FEB-81',1250,500,30);";
                con.Open();
                SqlCommand cmd = new SqlCommand(querystring, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong..." + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private static void DeleteData()
        {
            SqlConnection con = null;
            try
            {
                string ConString = @"Data Source=DESKTOP-4K86B5U;Initial Catalog=Swabhav;User ID=sa;Password=root";
                con = new SqlConnection(ConString);
                string querystring = "DELETE FROM EMP WHERE ENAME='DEEPAK' ;";
                con.Open();
                SqlCommand cmd = new SqlCommand(querystring, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data Deleted !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong..." + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
