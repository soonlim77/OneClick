using OneClick.Helper;
using OneClick.Interface;
using OneClick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OneClick.Content
{
    public class SE3EmailContent : IEmailContent
    {
        public EmailInfo ConstructBody(EmailInfo e, int part)
        {

            e.Content = new EmailContent("Help Desk Follow up Email #3 on ticket " + e.Ticket);
           // e.Content.Body = ConstructSEContent(e);
            e.Content.Body = ConstructSEContent(e, part);
            return e;

        }


        private string ConstructSEContent(EmailInfo e, int n)
        {


            var caption=  n ==1? "IT Connect":"UPtime";
             var urlLink = n == 1 ? ConfigurationManager.AppSettings.Get("Strike3ITConnectURL"): ConfigurationManager.AppSettings.Get("Strike3UPtimeURL");

            e.Content.Body = null;

            e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'>Dear " + StringHelper.CapitalFirstChar(e.EmployeeName) + ",<br>";
           
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>This email is with regards to ticket <span style='color:#FF0000'><b> " + StringHelper.HTMLEscape(e.Ticket) + " </b> </span style='color:#FF0000'> that has been opened for you.";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We have tried reaching out to you twice, in order to follow up on your case, however did not receive any response.<br>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We will proceed to resolve this ticket as there was no response from your end. In case, you still need assistance on this issue please reach out to the ServiceDesk via ITConnect and state this ticket number as reference.<br>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Note: <i> 'The ticket can be reopened using Check status option available on  <a href="+urlLink+"> " + caption+" </a>  within 5 business days'</i>.<br>";
            //    e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>On the other hand, if your issue has been resolved, please confirm if your case can be closed.<br>" ;
            e.Content.Body += "<hr align='left';width='50%';COLOR=' #5F249F';size='6'>";
            e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> For quicker response, Kindly reach us via Chat/Call Service <a href='https://uptime.dxc.com/'> DXC Support </a>";

            return e.Content.Body;
        }
    }
}
