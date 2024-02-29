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

    public class StrikeOne : IComposeEmail
    {
        public bool ComposeEmail(EmailInfo ef)
        {
            IEmailContent econtent = TemplateFactory.GetSEEmailOption(GlobalVariable.rbSEchoice);


            //for (int i = 0; i < 2; i++)
            //{
            econtent.ConstructBody(ef,0);

               EmailHelper.GetInstance().CreateOutlookEmail(ef);

           // }

            return true;
        }

     
    }
}
