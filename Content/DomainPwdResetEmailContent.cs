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
    public class DomainPwdResetEmailContent : IEmailContent
    {




        public EmailInfo ConstructBody(EmailInfo e, int part)
        {
            // setup content like body, subject line 
            //   return new EmailInfo();
            e.Content = new EmailContent("Domain Account Password Reset - Email " + part + "/2 for ticket " + e.Ticket);
            e.Content.Body = part == 1 ? ConstructDomainAcctPwdPart1(e) : ConstructDomainAcctPwdPart2(e);
            return e;

        }

        private string ConstructDomainAcctPwdPart1(EmailInfo e)
        {

            e.Content.Body = null;

            //e.Content.Body += "<HTML><BODY><img src='C:/Ext Proj/OneClick/Images/PWResetEmail1.JPG' Heigth='200' width='400'>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Hello " + StringHelper.CapitalFirstChar(e.ManagerName) + ",<br>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Your employee <span style=''color:#FF0000''><b> " + StringHelper.CapitalFirstChar(e.EmployeeName) + " </b> </span style=''color:#FF0000''> has requested their  Domain account password to be reset.<br>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We will need you to communicate the password to your employee. The password will be sent in a separate email.<br>";
            e.Content.Body += "<hr align='left';width='50%';COLOR=' #5F249F';size='6'>";
            e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> Please do not reply on this email, kindly reach us via chat/call <a href='https://uptime.dxc.com/'> DXC Support </a>, if need be  </BODY></HTML> ";


            return e.Content.Body;
        }

        private string ConstructDomainAcctPwdPart2(EmailInfo e)
        {


            e.Content.Body = null;

            // e.Content.Body+= "<HTML><BODY><img src='../Images/PWResetEmail2.JPG' Heigth='200' width='400'>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'> Hello " + StringHelper.CapitalFirstChar(e.EmployeeName) + ",<br>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We previously contacted you regarding the reset of the Domain account password for one of your employees. Please communicate the new password to the employee we mentioned. <br>";
            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>New password: <span style=color:'#FF0000'> <b>" + StringHelper.HTMLEscape(e.Key.Trim()) + " </b> </span style='color:#FF0000'> <br>";
            e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'>Employee will need to login to <a href='https://idm.dxc.com/cscidm/PasswordServices.jsf'> Universal ID </a> tool to change the password and also set security Questions for password recovery.";
            e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Important:</b><a href='https://csc.service-now.com/selfservice/article_detail.do?sysparm_document_key=kb_knowledge,6be8d1e5dbfd1fc0f9dfcebe3b9619d2'> Universal ID Password: Reset, Storage, and Sharing </a> tool to change the password and also set security Questions for password recovery.";
            e.Content.Body += "<hr align='left';width='50%';COLOR='#5F249F';size='6'>";
            e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> Please do not reply on this email, kindly reach us via chat/call <a href='https://uptime.dxc.com/> DXC Support </a>, if need be </BODY></HTML> ";

            return e.Content.Body;

        }


     
    }
}
