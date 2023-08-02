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
    }
}
