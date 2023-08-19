namespace CPW211_BookRegistration
{
    public class Book
    {
        /// <summary>
        ///  Creates book with ISBN, title, and price
        /// </summary>
        /// <param name="isbn">The book's ISBN number</param>
        /// <param name="title">The book's title</param>
        /// <param name="price">The books price</param>
        public Book(string isbn, string title, decimal price) 
        {
            ISBN = isbn;
            Title = title;
            Price = price;
        }

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

        public string TitleAndPrice
        {
            get { return Title + ", " + Price.ToString("C"); }
        }


        /// <summary>
        /// String representation of the book
        /// </summary>
        /// <returns>Returns Book title</returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
