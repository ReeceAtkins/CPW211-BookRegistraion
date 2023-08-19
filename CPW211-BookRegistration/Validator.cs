using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CPW211_BookRegistration
{
    internal class Validator
    {
        /// <summary>
        /// checks if a textbox is filled
        /// </summary>
        /// <param name="box">the given textbox</param>
        /// <returns>true if the given textbox is filled, false otherwise</returns>
        public static bool IsPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// checks if an ISBN is valid
        /// </summary>
        /// <param name="isbn">the given ISBN</param>
        /// <returns>true if the given ISBN contains digits only and has maximum of 13 digits, false otherwise</returns>
        public static bool IsValidISBN(string isbn)
        {
            isbn = RemoveDashesAndSpaces(isbn);

            // checks if contains only digits
            bool containsDigitOnly = Regex.IsMatch(isbn, @"^\d+$");

            return isbn.Length <= 13 && containsDigitOnly;
        }

        /// <summary>
        /// removes all dashes and white spaces within a string
        /// </summary>
        /// <param name="input">the given string</param>
        /// <returns>a string without any dashes and white spaces</returns>
        public static string RemoveDashesAndSpaces(string input)
        {
            // Removes any spaces within the string
            input = input.Replace(" ", "");

            // Remove any dashes within the string
            input = input.Replace("-", "");

            return input;
        }
    }
}
