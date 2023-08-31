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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                ClearErrorMessages();

                if (cboCustomer.SelectedIndex != -1)
                {
                    Customer customerToDelete = cboCustomer.SelectedItem as Customer;
                    CustomerDB.Delete(customerToDelete);
                    cboCustomer.SelectedIndex = -1;
                    PopulateCustomerList();
                }
                else if (cboBook.SelectedIndex != -1)
                {
                    Book bookToDelete = cboBook.SelectedItem as Book;
                    BookDB.Delete(bookToDelete);
                    cboBook.SelectedIndex = -1;
                    PopulateBookList();
                }
                else if (cboRegistration.SelectedIndex != -1)
                {
                    Registration regToDelete = cboRegistration.SelectedItem as Registration;
                    BookRegistrationDB.Delete(regToDelete);
                    cboRegistration.SelectedIndex = -1;
                    PopulateRegistrationList();
                }
            }
        }

        private bool IsValid()
        {
            bool isValid = true;
            if (cboCustomer.SelectedIndex == -1 &&
                cboBook.SelectedIndex == -1 &&
                cboRegistration.SelectedIndex == -1) 
            {
                lblBookError.Text = "Please select a Book";
                lblCustomerError.Text = "Please select a Customer";
                lblRegistrationError.Text = "Please select a Registration";

                isValid = false;
            }

            return isValid;
        }

        private void ClearErrorMessages()
        {
            lblBookError.Text = string.Empty;
            lblCustomerError.Text = string.Empty;
            lblRegistrationError.Text = string.Empty;
        }

        public void PopulateCustomerList()
        {
            cboCustomer.Items.Clear();

            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer currCustomer in customers)
            {
                cboCustomer.Items.Add(currCustomer);
            }
        }

        public void PopulateBookList()
        {
            cboBook.Items.Clear();

            List<Book> books = BookDB.GetAllBooks();

            foreach (Book currBook in books)
            {
                cboBook.Items.Add(currBook);
            }
        }

        private void PopulateRegistrationList()
        {
            cboRegistration.Items.Clear();

            List<Registration> registrations = BookRegistrationDB.GetAllRegistration();

            foreach (Registration CurrReg in registrations)
            {
                cboRegistration.Items.Add(CurrReg);
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            PopulateBookList();
            PopulateCustomerList();
            PopulateRegistrationList();
        }
    }
}
