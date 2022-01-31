using System;
using System.Text.RegularExpressions;
using UserRegistration_Lambda;

namespace UserRegistrationUsingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-1

            Console.WriteLine("Welcome to User Reg using Lambda Expressions!");
            Console.WriteLine("Enter First Name :");
            string name = Console.ReadLine();
            //reference fot regex class
            RegeX regex = new RegeX();
            //if regex is valid 
            //it exexutes as valid firstname
            //otherwise invalid firstname
            if (regex.ValidFirstName(name))
                Console.WriteLine("First Name is VALID !!");
            else
                Console.WriteLine("First Name is INVALID !!");

            //UC-2

            Console.WriteLine("Enter Last Name :");
            //if regex is valid 
            //it executes as valid lastname
            //otherwise invalid lastname
            string lastname = Console.ReadLine();
            if (regex.ValidLastName(lastname))
                Console.WriteLine("Last Name is VALID !!");
            else
                Console.WriteLine("Last Name is INVALID !!");

            //UC-3

            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            //if regex is valid 
            //it executes as valid email
            //otherwise invalid email
            if (regex.ValidEmail(email))
                Console.WriteLine("Email is VALID !!");
            else
                Console.WriteLine("Email is INVALID !!");

            //UC-4

            Console.WriteLine("Enter Mobile Number :");
            string mobilenum = Console.ReadLine();
            //if regex is valid 
            //it executes as valid mobilenumber
            //otherwise invalid mobilenumber
            if (regex.ValidMobile(mobilenum))
                Console.WriteLine("Mobile Number is VALID !!");
            else
                Console.WriteLine("Mobile Number is INVALID !!");

            //UC-5

            Console.WriteLine("Enter Password :");
            string Rule1 = Console.ReadLine();
            //if regex is valid 
            //it executes as valid rule1
            //otherwise invalid rule1
            if (regex.ValidCondition1(Rule1))
                Console.WriteLine("Password is VALID !!");
            else
                Console.WriteLine("Password is INVALID !!");

            //UC-6

            Console.WriteLine("Enter Password :");
            string Rule2 = Console.ReadLine();
            //if regex is valid 
            //it executes as valid rule2
            //otherwise invalid rule2
            if (regex.ValidCondition2(Rule2))
                Console.WriteLine("Password is VALID !!");
            else
                Console.WriteLine("Password is INVALID !!");

            //UC-7

            Console.WriteLine("Enter Password :");
            string Rule3 = Console.ReadLine();
            //if regex is valid 
            //it executes as valid rule3
            //otherwise invalid rule3
            if (regex.ValidCondition3(Rule3))
                Console.WriteLine("Password is VALID !!");
            else
                Console.WriteLine("Password is INVALID !!");

            //UC-8

            Console.WriteLine("Enter Password :");
            string Rule4 = Console.ReadLine();
            //if regex is valid 
            //it executes as valid rule4
            //otherwise invalid rule4
            if (regex.ValidCondition4(Rule4))
                Console.WriteLine("Password is VALID !!");
            else
                Console.WriteLine("Password is INVALID !!");

            //UC-9

            Console.WriteLine("Enter Sample Emails to Test :");
            string sampleemail = Console.ReadLine();
            //if regex is valid
            //it executes as valid sample email
            //otherwise invalid sample email
            if (regex.SampleEmail(sampleemail))
                Console.WriteLine("Sample Email is VALID !!");
            else
                Console.WriteLine("Sample Email is INVALID !!");
        }
    }
}