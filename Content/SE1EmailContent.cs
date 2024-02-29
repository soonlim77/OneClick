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
using OneClick.Content;
using OneClick.Interface;


namespace OneClick.Content
{
    public class SE1EmailContent : IEmailContent
    {
        public EmailInfo ConstructBody(EmailInfo e, int part)
        {

            e.Content = new EmailContent("Help Desk Follow up Email #1 on ticket " + e.Ticket);
            e.Content.Body = ConstructSEContent(e);
            return e;

        }


        private string ConstructSEContent(EmailInfo e)
        {

            e.Content.Body = null;

               e.Content.Body+= "<p style='font-family:GT Walsheim Pro;font-size:11pt'>Dear " + StringHelper.CapitalFirstChar(e.EmployeeName)+",<br>" ;
            //  e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Good Day!<br>" ;
            //  e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>I am following up on your ticket <span style='color:#FF0000'><b> "+ StringHelper.HTMLEscape(e.Ticket)+" </b> </span style='color:#FF0000'> regarding <span style='color:#FF0000'><b> "+ StringHelper.HTMLEscape(e.Issue.Trim())+" </b> </span style='color:#FF0000'>.<br>" ;
              e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>This is regarding ticket # <span style='color:#FF0000'><b> " + StringHelper.HTMLEscape(e.Ticket) + " </b> </span style='color:#FF0000'> which is still in open status.";
              e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Please get back to us with your preferred contact mode and time to assist you further. <br>";
              e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>In case the issue is already resolved or no further assistance is required, please let us know so that we can go ahead and close the ticket.<br>";
              e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>This ticket will be closed in <b> 3 </b>days, if we do not hear from you.<br>";
           //    e.Content.Body+= "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>On the other hand, if your issue has been resolved, please confirm if your case can be closed.<br>" ;
              e.Content.Body+= "<hr align='left';width='50%';COLOR=' #5F249F';size='6'>" ;
              e.Content.Body+= "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> For quicker response, Kindly reach us via Chat/Call Service <a href='https://uptime.dxc.com/'> DXC Support </a>" ;

                return e.Content.Body;
        }

    }
}
