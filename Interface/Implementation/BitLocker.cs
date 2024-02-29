using OneClick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;
using OneClick.Global;
using OneClick.Factory;
using System.Configuration;
using OneClick.Helper;

namespace OneClick.Interface.Implementation
{
    public class BitLocker : IComposeEmail
    {
        public bool ComposeEmail(EmailInfo ef)
        {
            string imgLockerHeadName = "BitLockerheading.JPG";

            IEmailContent econtent = TemplateFactory.GetEmailOption(GlobalVariable.rbselection);
            //setup email content body
                        
            econtent.ConstructBody(ef, 0);
             
            EmailHelper.GetInstance().CreateOutlookEmail(ef, imgLockerHeadName);


            return true;

        }



       
    }
}
