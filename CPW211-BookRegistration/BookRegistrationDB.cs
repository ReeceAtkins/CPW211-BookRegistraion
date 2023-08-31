using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_BookRegistration
{
    static class BookRegistrationDB
    {
        public static int RegisterBook(Registration r)
        {
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            // prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            // parameterized query
            insertCmd.CommandText = "INSERT INTO Registration (CustomerId, ISBN, RegDate) " +
                                    "VALUES (@customerId, @isbn, @regDate) ";
            insertCmd.Parameters.AddWithValue("@customerId", r.CustomerID);
            insertCmd.Parameters.AddWithValue("@isbn", r.ISBN);
            insertCmd.Parameters.AddWithValue("@regDate", r.RegDate);

            // open connection to the database
            con.Open();

            // execute insert qury
            int numberOfRows = insertCmd.ExecuteNonQuery();

            return numberOfRows;
        }

        public static int CountRegistration(int customerID, string isbn)
        {
            // Get connection
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            // Prepare the query 
            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT CustomerID, ISBN, RegDate " +
                                    "FROM Registration " +
                                    "WHERE CustomerID = @customerID " +
                                    "        AND ISBN = @isbn ";
            selectCmd.Parameters.AddWithValue("@customerID", customerID);
            selectCmd.Parameters.AddWithValue("@isbn", isbn);

            // open connection to the database
            con.Open();

            int regCount = 0;

            // Execute the query and use results
            using (SqlDataReader reader = selectCmd.ExecuteReader())
            {
                // Check if any rows are returned
                if (reader.HasRows)
                {
                    // Iterate over the rows
                    while (reader.Read())
                    {
                        // Increment the counter for each row
                        regCount++;
                    }
                }
            };

            return regCount;
        }

        public static List<Registration> GetAllRegistration()
        {
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT CustomerID, ISBN, RegDate" +
                            " FROM Registration" +
                            " ORDER BY CustomerID";

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Registration> regBooks = new();

            while (reader.Read())
            {
                int customerId = Convert.ToInt32(reader["CustomerID"]);
                string ISBN = reader["ISBN"].ToString();
                DateTime regDate = Convert.ToDateTime(reader["RegDate"]);

                Registration tempRegBook = new Registration(customerId, ISBN, regDate);
                regBooks.Add(tempRegBook);
            }

            return regBooks;
        }
    }
}
