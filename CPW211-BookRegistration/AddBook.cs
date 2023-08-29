using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW211_BookRegistration
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string isbn = txtISBN.Text;
                isbn = Validator.RemoveDashesAndSpaces(isbn);
                decimal price = Convert.ToDecimal(txtPrice.Text);
                string title = txtTitle.Text;

                Book bookToAdd = new Book(isbn, title, price);

                int count = BookDB.Add(bookToAdd);

                if (count > 0)
                {
                    MessageBox.Show($"{bookToAdd.Title} has been added succesfully!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"We are experiencing some database issues. Please try again later!");
                }
            }
        }

        private bool IsValid()
        {
            // checks if all fields are filled
            if (!Validator.IsPresent(txtISBN) ||
                !Validator.IsPresent(txtPrice) ||
                !Validator.IsPresent(txtTitle))
            {
                lblErrorMsg.Text = "Please don't leave any blank!";
                return false;
            }
            // checks if price is valid
            else if (!double.TryParse(txtPrice.Text, out double price) || price < 0)
            {
                lblErrorMsg.Text = "Please enter a valid price!";
                return false;
            }
            // checks ISBN
            else
            {
                string isbn = txtISBN.Text;

                isbn = Validator.RemoveDashesAndSpaces(isbn);

                // checks if valid ISBN
                if (!Validator.IsValidISBN(isbn))
                {
                    lblErrorMsg.Text = "Please enter a valid ISBN";
                    return false;
                }
                // checks if ISBN existed
                else
                {
                    List<Book> books = BookDB.GetAllBooks();

                    foreach (Book book in books)
                    {
                        book.ISBN = Validator.RemoveDashesAndSpaces(book.ISBN);
                        if (isbn == book.ISBN)
                        {
                            lblErrorMsg.Text = "This ISBN already exists!";
                            return false;
                        }
                    }
                }
            }

            lblErrorMsg.Text = "";
            return true;
        }

        private void ResetForm()
        {
            txtTitle.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            lblErrorMsg.Text = "";
        }
    }
}
