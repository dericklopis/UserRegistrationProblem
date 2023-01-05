using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems Statement Using REGEX");
            RegexClass userValidation = new RegexClass();
            Console.WriteLine("Enter The First Name: ");
            string firstname = Console.ReadLine();
            userValidation.ValidationFirstName(firstname);

            Console.WriteLine("Enter The Last Name: ");
            string lastname = Console.ReadLine();
            userValidation.ValidationLastName(lastname);

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            userValidation.ValidationFirstName(email);

            Console.WriteLine("Enter PhoneNumber: ");
            string phonenumber = Console.ReadLine();
            userValidation.ValidationPhoneNumber(phonenumber);

            Console.WriteLine("Enter password 8 characters");
            string password = Console.ReadLine();
            userValidation.ValidationPassword(password);

            Console.WriteLine("Enter password 1 uppercase");
            string Uppercase = Console.ReadLine();
            userValidation.ValidationUppercase(Uppercase);
        }
    }
}
