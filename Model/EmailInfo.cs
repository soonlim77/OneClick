using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Model
{
    public class EmailInfo
    {

        public string From{ get; set; }
        public string To{ get; set; }
        public string CC{ get; set; }
        public string ManagerName { get; set; }
        public string EmployeeName { get; set; }
        public string Key { get; set; }
        public string Ticket{ get; set; }
        public string Issue { get; set; }
        public string Password{ get; set; }
        public int EmailGroup { get; set; }
        public EmailContent Content{ get; set; }

        public EmailInfo()
        {

        }
        public EmailInfo(string To, string CC, string ManagerName, string EmployeeName,
                          string Key,string Ticket)
        {
            this.To = To != string.Empty ? To: To;
            this.CC = CC!=string.Empty ? CC : CC;
            this.ManagerName = ManagerName!=string.Empty?  ManagerName : "Rossy";
            this.EmployeeName = EmployeeName!=string.Empty?EmployeeName:"Soon Lim";
            this.Key = Key!=string.Empty? Key:"KKKKK";
            this.Ticket = Ticket!=string.Empty?Ticket: "$TTYYTTT#";
            this.Issue = Issue != string.Empty ? Issue : "IIIiiiIIIii";

           

        }

        public EmailInfo(string To, string CC,  string EmployeeName,string Ticket, string Issue)
        {
          //  this.From=
            this.To = To != string.Empty ? To : To;
            this.CC = CC != string.Empty ? CC : CC;
            this.EmployeeName = EmployeeName != string.Empty ? EmployeeName : "Soon Lim";
            this.Ticket = Ticket != string.Empty ? Ticket : "$565&55##";
            this.Issue = Issue != string.Empty ? Issue : "fdfdgdsfg";



        }


        //public EmailInfo(string To, string CC, string EmployeeName, string ManagerName, string Password)
        //{
        //    this.To = To != string.Empty ? To : To;
        //    this.CC = CC != string.Empty ? CC : CC;
        //    this.ManagerName = ManagerName != string.Empty ? ManagerName : "Rossy";
        //    this.EmployeeName = EmployeeName != string.Empty ? EmployeeName : "Soon Lim";
        //    this.Password = Password != string.Empty ? Password : "##$$$##$#";

        //}
    }
}
