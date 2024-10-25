using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mid_lab
{
    internal class question2
    {
        static void Main(string[] args)
        {
            string registrationDigits = "57";
            char firstNameChar = 'i';
            char lastNameChar = 'm';
            string favoriteMovieChars = "50";
            string specialChars = "@$%!&*";
            int length = 14;


            Random random = new Random();
            StringBuilder password = new StringBuilder();


            password.Append(registrationDigits);
            password.Append(firstNameChar);
            password.Append(lastNameChar);
            password.Append(favoriteMovieChars);


            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + specialChars;
            while (password.Length < length)
            {
                char nextChar = allowedChars[random.Next(allowedChars.Length)];
                if (nextChar != '#')
                    password.Append(nextChar);
            }


            string regexPattern = @"^(?!.*#).{14}$";
            if (Regex.IsMatch(password.ToString(), regexPattern))
            {
                Console.WriteLine("Generated Password: " + password);
            }
            else
            {
                Console.WriteLine("Password generation failed to meet specifications.");
            }
        }
    }
}
