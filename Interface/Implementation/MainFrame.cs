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
    public class MainFrame : IComposeEmail
    {
        public bool ComposeEmail(EmailInfo ef)
        {
            IEmailContent econtent = TemplateFactory.GetEmailOption(GlobalVariable.rbselection);

            for (int i = 0; i < 2; i++)
            {
                econtent.ConstructBody(ef, i + 1);
                EmailHelper.GetInstance().CreateOutlookEmail(ef, string.Format("MainframePWReset{0}.JPG", i + 1));
            }

            return true;
           

        }
    }
}
