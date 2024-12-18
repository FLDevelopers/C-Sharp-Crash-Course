using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class BestPractices
    {
        void BestPracticesMain()
        {
            // Best Practices

            // Naming Conventions
            int orderCount;
            int customerId;

            const int MAX_LIMIT = 100;
            const double PI = 3.14;

            void ProcessOrder(string customerName) { }

            // Comments and Documentation

            // this is method return the sum of all items of the list.
            int CalculateTotal(List<int> orderItems)
            {
                return orderItems.Sum();
            }

            // Exception handling
            using (SqlConnection connection = new SqlConnection("connectionString"))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    Console.WriteLine("Database connection established successfully.");

                    // Simple SQL command to execute
                    string query = "SELECT TOP 1 * FROM your_table_name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Data: {reader[0]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
