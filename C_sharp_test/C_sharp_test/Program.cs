using System;

using MySql.Data;
using MySql.Data.MySqlClient;



namespace C_sharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=canoe;port=3306;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT userID from users";
                // Perform database operations

               MySqlDataReader reader = cmd.ExecuteReader();

               while (reader.Read())
                {
                 Console.WriteLine(reader.GetValue(0).ToString());
                }
                // Console.WriteLine(reader.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
