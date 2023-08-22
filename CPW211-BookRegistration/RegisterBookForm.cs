namespace CPW211_BookRegistration
{
    public partial class RegisterBookForm : Form
    {
        public RegisterBookForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
        }
    }
}