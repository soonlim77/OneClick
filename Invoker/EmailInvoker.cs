using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneClick.Interface;
using OneClick.Model;

namespace OneClick.Invoker
{
     public  class EmailInvoker
    {
        private IComposeEmail _emailinvoker;


        public EmailInvoker( IComposeEmail emailobject)
        {
            _emailinvoker = emailobject;

        }


        public void ComposeEmail(EmailInfo ef)
        {

            if (ef != null)
                _emailinvoker.ComposeEmail(ef);


        }
    }
}
