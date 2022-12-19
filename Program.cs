using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regrex_Password_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            Console.ReadLine();
            Console.WriteLine("Enter password");

            Console.WriteLine("Password must be of 8 letters which must include" +
                "\nUppercase and Lowercase alphabet, special symbol and number");
            bool result = false;
            while (!result)
            {

                string password = Console.ReadLine();

                result = Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8}$");

                if (!result)
                {
                    Console.WriteLine("{0} is not a valid password ", password);
                    Console.WriteLine("Please enter valid password");
                }
                else
                {
                    Console.WriteLine("Password successfully set");
                }
            }
            Console.ReadKey();
        }
    }
}
