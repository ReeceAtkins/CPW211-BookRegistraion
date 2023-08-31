using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_BookRegistration
{
    static class CustomerDB
    {
        public static int Add(Customer c)
        {
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            // prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            // parameterized query
            insertCmd.CommandText = "INSERT INTO Customer(Title, FirstName, LastName, DateOfBirth) " +
                                    "VALUES (@title, @firstName, @lastName, @dob)";
            insertCmd.Parameters.AddWithValue("@title", c.Title);
            insertCmd.Parameters.AddWithValue("@firstName", c.FirstName);
            insertCmd.Parameters.AddWithValue("@lastName", c.LastName);
            insertCmd.Parameters.AddWithValue("@dob", c.DateOfBirth);

            // open connection to the database
            con.Open();

            // execute insert qury
            int count = insertCmd.ExecuteNonQuery();

            return count;
        }


        public static List<Customer> GetAllCustomers()
        {
            // Get connection
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            // Prepare the query 
            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT CustomerId, Title, FirstName, LastName, DateOfBirth " +
                                    "FROM Customer " +
                                    "ORDER BY LastName";

            // open connection to the database
            con.Open();

            // Execute the query and use results
            SqlDataReader reader = selectCmd.ExecuteReader();

            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CustomerID"]);
                string title = reader["Title"].ToString();
                string firstName = reader["FirstName"].ToString();
                string lastName = reader["LastName"].ToString();

                DateTime dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                Customer tempCus = new Customer(title, firstName, lastName, dateOfBirth);
                tempCus.CustomerID = id;
                customers.Add(tempCus);
            }

            // Return list of Customers
            return customers;
        }

        public static void Delete(Customer customer)
        {
            using SqlConnection con = DBHelper.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "Delete from Customer " +
                                    "Where CustomerID = @id";
            insertCmd.Parameters.AddWithValue("@id", customer.CustomerID);

            con.Open();

            insertCmd.ExecuteNonQuery();

            MessageBox.Show("Customer Deleted");
        }
    }
}
