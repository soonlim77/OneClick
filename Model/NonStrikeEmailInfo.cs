using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Model
{
   public class NonStrikeEmailInfo:EmailInfo
    {

        public NonStrikeEmailInfo(string To, string CC, string ManagerName, string EmployeeName, string Key, string Ticket) : base(To, CC, ManagerName, EmployeeName, Key, Ticket)
        {
            this.From = ConfigurationManager.AppSettings.Get("CommonSender");
            this.EmailGroup = 1;
            //base(To, CC, EmployeeName, Ticket, Issue);
        }
        public NonStrikeEmailInfo()
        {

        }
    }
}
