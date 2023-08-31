using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_BookRegistration
{
    static class BookDB
    {
        public static int Add(Book b)
        {
            // use "using" statement to close connection automatically
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            // prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            // parameterized query
            insertCmd.CommandText = "INSERT INTO Book(ISBN, Price, Title) " +
                                    "VALUES (@isbn, @price, @title) ";
            insertCmd.Parameters.AddWithValue("@isbn", b.ISBN);
            insertCmd.Parameters.AddWithValue("@price", b.Price);
            insertCmd.Parameters.AddWithValue("@title", b.Title);

            // open connection to the database
            con.Open();

            // execute insert qury
            int count = insertCmd.ExecuteNonQuery();

            return count;
        }

        public static List<Book> GetAllBooks()
        {
            // use "using" statement to close connection automatically
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            // Prepare the query 
            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT ISBN, Title, Price " +
                                    "FROM Book " +
                                    "ORDER BY ISBN";

            // open connection to the database
            con.Open();

            // Execute the query and use results
            SqlDataReader reader = selectCmd.ExecuteReader();

            List<Book> books = new();

            while (reader.Read())
            {
                string isbn = reader["ISBN"].ToString();
                string title = reader["Title"].ToString();
                decimal price = Convert.ToDecimal(reader["Price"]);

                Book bookToRetrieve = new Book(isbn, title, price);
                books.Add(bookToRetrieve);
            }

            // Return list of Customers
            return books;
        }

        public static void Delete(Book book)
        {
            using SqlConnection con = DBHelper.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "Delete from Book " +
                                    "Where ISBN = @isbn";
            insertCmd.Parameters.AddWithValue("@isbn", book.ISBN);

            con.Open();

            insertCmd.ExecuteNonQuery();

            MessageBox.Show("Book Deleted");
        }
    }
}
