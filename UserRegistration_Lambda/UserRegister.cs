using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Lambda
{
    public class UserRegister
    {
        //variable
        private string message;

        public UserRegister(string message)
        {
            this.message = message;
        }

        public string FirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }

        public string LastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }

        public string Email()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }

        public string MobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }

        public string Password()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }

        //UC-11
        public UserRegister()
        {
        }

        RegeX Obj = new RegeX();
        public string MultipleEmails(string e1, string e2)
        {

            bool b1 = Obj.ValidEmail(e1);

            bool b2 = Obj.ValidEmail(e2);

            if (b1 && b2)
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }

        //UC-12

        public void CheckFirstName(string firstName)
        {
            if (Obj.ValidFirstName(firstName))
                Console.WriteLine("Valid First Name !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "First Name is Invalid !!");
        }

        public void CheckLastName(string lastName)
        {
            if (Obj.ValidLastName(lastName))
                Console.WriteLine("Valid Last Name !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Last Name is Invalid !!");
        }

        public void CheckEmail(string email)
        {
            if (Obj.ValidEmail(email))
                Console.WriteLine("Valid Email !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Email is Invalid !!");
        }

        public void CheckMobile(string mobileNumber)
        {
            if (Obj.ValidMobile(mobileNumber))
                Console.WriteLine("Valid Mobile Number !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILENUMBER, "Mobile number is Invalid !!");
        }

        public void CheckPassword(string password)
        {
            if (Obj.ValidCondition1(password) && Obj.ValidCondition4(password))
                Console.WriteLine("Valid Password !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid !!");
        }
    }
}