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
