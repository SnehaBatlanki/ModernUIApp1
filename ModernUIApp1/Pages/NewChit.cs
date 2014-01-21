using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModernUIApp1.Pages
{
    class NewChit
    {
        public NewChit()
        {
           
            string connectionString = "Data Source=(local);Initial Catalog=MasterDb;Integrated Security=SSPI;User Id=chitfunds; Password=sneha;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string str = "CREATE DATABASE @chit on()";
                 using (SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM Dogs1", con))
                 { }

            }
        }
    }
}


