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
            PopulateBook();
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
        }
    }
}