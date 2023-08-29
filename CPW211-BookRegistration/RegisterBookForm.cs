namespace CPW211_BookRegistration
{
    public partial class RegisterBookForm : Form
    {
        public RegisterBookForm()
        {
            InitializeComponent();
        }

        private void RegisterBookForm_Load(object sender, EventArgs e)
        {
            PopulateCustomer();
            PopulateBook();
        }

        private void PopulateCustomer()
        {
            // Clear any previous objects
            cboCustomers.Items.Clear();

            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer currentCustomer in customers)
            {
                cboCustomers.Items.Add(currentCustomer);
            }

            cboCustomers.SelectedIndex = -1;

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook();
            addBookForm.ShowDialog();
            ResetForm();
        }


        private void PopulateBook()
        {
            // Clear any previous objects
            cboBooks.Items.Clear();

            List<Book> Books = BookDB.GetAllBooks();

            foreach (Book currentBook in Books)
            {
                cboBooks.Items.Add(currentBook);
            }

            cboBooks.SelectedIndex = -1;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
            ResetForm();
        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex == -1 || cboBooks.SelectedIndex == -1)
            {
                lblErrorMsg.Text = "Please select a customer and a book to register!";
                return;
            }

            lblErrorMsg.Text = "";

            Customer chosenCustomer = (Customer)cboCustomers.SelectedItem;
            Book chosenBook = (Book)cboBooks.SelectedItem;
            DateTime pickedDate = dtpDate.Value;

            int regCount = BookRegistrationDB.CountRegistration(chosenCustomer.CustomerID, chosenBook.ISBN);

            if (regCount != 0)
            {
                MessageBox.Show($"The registration of {chosenBook.Title} for {chosenCustomer.FullName} already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetForm();
                return;
            }
            else
            {
                Registration reg = new Registration(chosenCustomer.CustomerID, chosenBook.ISBN, pickedDate);

                int numberOfRows = BookRegistrationDB.RegisterBook(reg);

                if (numberOfRows == 0)
                {
                    MessageBox.Show("We are experiencing some server issues. Please try again later!");
                    ResetForm();
                }
                MessageBox.Show($"{chosenBook.Title} has been succesfully registered for {chosenCustomer.FullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();

            }
        }

        private void ResetForm()
        {
            cboCustomers.SelectedIndex = -1;
            cboBooks.SelectedIndex = -1;
            lblErrorMsg.Text = "";
            dtpDate.Value = DateTime.Today;
            PopulateCustomer();
            PopulateBook();
        }

        private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }
    }
}