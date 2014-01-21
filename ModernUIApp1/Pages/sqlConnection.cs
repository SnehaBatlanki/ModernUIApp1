using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModernUIApp1.Pages
{
    class sqlConnection
    {
      public void establishConnection()
        {
            string connectionString = "Data Source=(local);Initial Catalog=MasterDb;Integrated Security=SSPI;User Id=chitfunds; Password=sneha;";
          using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                con.Open();
                
                using (SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM Dogs1", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
            }
        }
    }
}
