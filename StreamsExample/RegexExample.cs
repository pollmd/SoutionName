using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StreamsExample
{
    internal class RegexExample
    {
        private void EmailPattern()
        {
            string emailPattern = "[a-z0-9_-]+@[a-z0-9_-]+.[a-z]";

            string email = Console.ReadLine();
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(regex.IsMatch(email));
        } 
    }
}
