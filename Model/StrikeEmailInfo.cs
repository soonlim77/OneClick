using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Model
{
   public class StrikeEmailInfo:EmailInfo
    {
        public StrikeEmailInfo(string To, string CC, string EmployeeName, string Ticket, string Issue) :base(To,CC,EmployeeName,Ticket,Issue)
        {
            this.From= ConfigurationManager.AppSettings.Get("StrikeCommonSender");
            this.EmailGroup = 2;
            //base(To, CC, EmployeeName, Ticket, Issue);
        }
        public StrikeEmailInfo()
        {
                
        }
    }
}
