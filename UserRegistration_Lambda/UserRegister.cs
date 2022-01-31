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
    }
}
