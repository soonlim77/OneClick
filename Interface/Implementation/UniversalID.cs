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
using OneClick.Properties;
using System.Net.Mail;
using OneClick.Helper;

namespace OneClick.Interface.Implementation
{
    public class UniversalID : IComposeEmail
    {
        public bool ComposeEmail(EmailInfo ef)
        {
            IEmailContent econtent = TemplateFactory.GetEmailOption(GlobalVariable.rbselection);
            //setup email content body

            for (int i = 0; i < 1; i++)
            {
                econtent.ConstructBody(ef,1+1);
                  EmailHelper.GetInstance().CreateOutlookEmail(ef, string.Format("PWResetEmail{0}.JPG",1+1));
               // CreateOutlookEmail(ef, string.Format("PWResetEmail{0}.JPG",i+1));


            }
                                  
            return true;

        }

      
    }
}
