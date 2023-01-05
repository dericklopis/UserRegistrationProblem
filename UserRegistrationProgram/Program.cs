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
            Console.WriteLine("welcome To Regex User Registration Problem");
            Console.ReadLine();
            RegexClass code = new RegexClass();
            Console.WriteLine("1 - Enter First Name");
            Console.WriteLine("2 - Enter Last Name");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    Console.ReadLine();
                    string firstName = Console.ReadLine();
                    code.name(firstName);
                    break;
            }
        }
    }
}
