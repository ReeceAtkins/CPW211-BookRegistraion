using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_BookRegistration
{
    internal class DBHelper
    {
        public static SqlConnection GetDatabaseConnection()
        {
            // establish connection to database
            return new SqlConnection("Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True");
        }
    }
}
