namespace CPW211_BookRegistration
{
    public partial class RegisterBookForm : Form
    {
        public RegisterBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook();
            addBookForm.ShowDialog();
        }
    }
}