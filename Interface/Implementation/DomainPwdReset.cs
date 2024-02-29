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
    public class DomainPwdReset : IComposeEmail
    {
        

        public bool ComposeEmail(EmailInfo ef)
        {
            IEmailContent econtent = TemplateFactory.GetEmailOption(GlobalVariable.rbselection);
            //setup email content body

            for (int i = 0; i < 2; i++)
            {
               ef= econtent.ConstructBody(ef, i + 1);

                EmailHelper.GetInstance().CreateOutlookEmail(ef, string.Format("Domain_Pass_Email_{0}.JPG", i + 1));

            }

            return true;

        }


        
    }
}
