using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class RuleThree
    {
        public void Numeric()
        {
            Console.WriteLine("Enter Password");
            var data = Console.ReadLine();
            string pattern = "^([A-Z{1,}[a-z]{6,}[0-9]{1,})$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is valid");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is invalid");
                Console.ResetColor();

            }
        }
    }
}
