using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace CPW211_BookRegistration
{
    public class Customer
    {
        private int _customerId;

        /// <summary>
        /// Creates a Customer with title, first Name, last Name, and date of birth
        /// </summary>
        /// <param name="title">Customer's title</param>
        /// <param name="firstName">Customer's first name</param>
        /// <param name="lastName">Customer's last name</param>
        /// <param name="dateOfBirth">Customer's date of birth</param>
        public Customer(string title, string firstName, string lastName, DateOnly dateOfBirth)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// The Customer's unique Id number
        /// </summary>
        public int CustomerID
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        /// <summary>
        /// The customer's title (ex. Mr.)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The customer's legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The customers legal last name
        /// </summary>
        private string LastName { get; set; }

        /// <summary>
        /// The customer's date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Formatted first name, last name
        /// </summary>
        /// <returns>Returns first name, last name</returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// Full name of a Customer
        /// </summary>
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
    }
}
