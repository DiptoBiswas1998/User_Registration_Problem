using System;
namespace User_Registration_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the User Registration Problem!");
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            bool firstNameResult = validateUserRegistration.ValidateFirstName(firstName);
            validateUserRegistration.PrintResult(firstNameResult);
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            bool lastNameResult = validateUserRegistration.ValidateLastName(lastName);
            validateUserRegistration.PrintResult(lastNameResult);
            Console.WriteLine("Enter your email : ");
            string eMail = Console.ReadLine();
            bool eMailResult = validateUserRegistration.ValidateEmail(eMail);
            validateUserRegistration.PrintResult(eMailResult);
            Console.WriteLine("Enter your mobile number : ");
            string mobileNo = Console.ReadLine();
            bool mobileNoResult = validateUserRegistration.ValidateMobileNo(mobileNo);
            validateUserRegistration.PrintResult(mobileNoResult);
        }
    }
}
