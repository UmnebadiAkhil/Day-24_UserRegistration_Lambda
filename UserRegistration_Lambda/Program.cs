using System;
using System.Text.RegularExpressions;
using UserRegistration_Lambda;

namespace UserRegistrationUsingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}