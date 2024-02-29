using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneClick.Model;

namespace OneClick.Interface
{
    public interface IEmailContent
    {

        EmailInfo ConstructBody(EmailInfo e,int part);
    }
}
