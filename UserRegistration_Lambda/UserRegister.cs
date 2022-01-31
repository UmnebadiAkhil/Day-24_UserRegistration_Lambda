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
}
