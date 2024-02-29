using OneClick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Interface
{
    public interface IComposeEmail
    {

        bool ComposeEmail(EmailInfo ef);
    }
}
