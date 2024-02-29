using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneClick.Helper;
using OneClick.Interface;


namespace OneClick.Model
{
    public class MainFrameEmailContent : IEmailContent
    {

        public PictureBox Logo { get; set; }
        public string Subject { get; set; }



       
            public EmailInfo ConstructBody(EmailInfo e, int part)
            {
                // setup content like body, subject line 
                //   return new EmailInfo();
                e.Content = new EmailContent("Mainframe Account Password Reset  - Email " + part + "/2 for ticket " + e.Ticket);
                e.Content.Body = part == 1 ? ConstructMainFrame1(e) : ConstructMainFrame2(e);
                return e;

            }


        private string ConstructMainFrame2(EmailInfo e)
        {

           e.Content.Body = null;


            e.Content.Body +="<br><p style='font-family:GT Walsheim Pro;font-size:11pt'> Hello " + StringHelper.CapitalFirstChar(e.ManagerName)+ ",<br>" ;
             e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We previously contacted you regarding the reset of the Mainframe account password for one of your employees.<br>" ;
             e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'>Please communicate the new password <span style='color:#FF0000'> <b>" + StringHelper.HTMLEscape(e.Key.Trim())+" </b> </span style='color:#FF0000'> to the employee we mentioned." ;
             e.Content.Body += "<hr align='left';width='50%';COLOR='#000000';size='6'>" ;
             e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> Please do not reply on this email, kindly reach us via chat/call <a href='https://uptime.dxc.com/'> DXC Support </a>, if need be";

            return e.Content.Body;

        }


        private string ConstructMainFrame1(EmailInfo e)
        {

            e.Content.Body = null;
           // e.Content.Body += string.Format("<HTML> <BODY><img src='cid:{0}'/>", "Domain:Pass:Email:1.JPG");

            e.Content.Body +="<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Hello "+e.ManagerName+ ",<br>" ;
              e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Your employee <span style='color:#FF0000'><b> "+e.EmployeeName+" </b> </span style='color:#FF0000'> has requested their Mainframe account password to be reset.<br>" ;
              e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We will need you to communicate the password to your employee. The password will be sent in a separate email.<br>" ;
              e.Content.Body += "<hr align='left';width='50%';COLOR=' #5F249F';size='6'>" ;
              e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> Please do not reply on this email, kindly reach us via chat/call <a href='https://uptime.dxc.com/'> DXC Support </a>, if need be";

            return e.Content.Body;
        }

    }
}
