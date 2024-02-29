using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneClick.Interface.Validator;
using OneClick.Interface;
using Microsoft.Office.Interop.Outlook;


namespace OneClick.Facade
{
     public class Processor
    {

        public void ProcessUniversalComposeEmail()
        {

           

        }


       

        public static IResult ValidateEmail(string email)
        {
            IResult ret = new EmailValidator().Validate(email);

            return ret;

        }
        
    }
}
