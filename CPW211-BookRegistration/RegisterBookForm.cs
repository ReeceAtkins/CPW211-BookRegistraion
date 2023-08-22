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
        }
    }
}