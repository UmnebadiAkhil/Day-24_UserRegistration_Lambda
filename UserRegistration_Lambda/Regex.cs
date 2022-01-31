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

        //UC-4
        //pattern for valid phonenumber
        public static string MobileNumREGEX = "^[91]{1}[ ]{1}[6-9]{1}[0-9]{9}$";

        public bool ValidMobile(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobileNumREGEX);
        }

        //UC-5
        //pattern for valid rule1
        public static string Condition1REGEX = "^[A-Za-z0-9@$!%*#?&]{8,}$";

        public bool ValidCondition1(string password)
        {
            return Regex.IsMatch(password, Condition1REGEX); ;
        }


    }
}