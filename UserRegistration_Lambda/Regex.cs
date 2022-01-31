using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_Lambda
{
    internal class RegeX
    {

        //UC-1
        //pattern for valid name
        public static string REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, REGEX);
        }
        //UC-2
        //pattern for valid name
        public static string LastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidLastName(string name)
        {
            return Regex.IsMatch(name, LastNameREGEX);
        }

        //UC-3
        //pattern for valid email
        public static string EmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";

        public bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, EmailREGEX);
        }
    }
}