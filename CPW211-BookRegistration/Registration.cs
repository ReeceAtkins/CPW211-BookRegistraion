using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_BookRegistration
{
    class Registration
    {
        public Registration(int customerId, string isbn, DateTime regDate)
        {
            CustomerID = customerId;
            ISBN = isbn;
            RegDate = regDate;
        }

        public int CustomerID { get; set; }

        public string ISBN { get; set; }

        public DateTime RegDate { get; set; }

        public override string ToString()
        {
            return $"CustomerID: {CustomerID} ISBN: {ISBN}";
        }
    }
}
