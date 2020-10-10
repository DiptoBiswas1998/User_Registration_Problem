using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace User_Registration_Problem
{
    class ValidateUserRegistration
    {
        private static readonly string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        private static readonly string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string FN)
        {
            return Regex.IsMatch(FN, Regex_FirstName);
        }
        public bool ValidateLastName(string LN)
        {
            return Regex.IsMatch(LN, Regex_LastName);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid name.");
            }
            else
            {
                Console.WriteLine("Invalid name.");
            }
        }
    }
}
