namespace CPW211_BookRegistration
{
    public class Book
    {
        /// <summary>
        /// The book's ISBN number
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The price of the book
        /// </summary>
        public decimal Price { get; set; }
    }
}
