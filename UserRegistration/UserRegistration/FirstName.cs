using System;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    internal class FirstName
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";

        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
    }
}