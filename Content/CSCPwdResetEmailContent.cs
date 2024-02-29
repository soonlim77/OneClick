using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneClick.Interface;
using OneClick.Model;
using OneClick.Helper;

namespace OneClick.Content
{
    public class CSCPwdResetEmailContent:IEmailContent
    {


        public CSCPwdResetEmailContent()
        {

        }

        public EmailInfo ConstructBody(EmailInfo e, int part)
        {

            e.Content = new EmailContent("Manager assistance needed: L - CSC Domain password reset");// + part + Stnd(part) + " Email");
            e.Content.Body = part == 1 ? ConstructCSCPwdResetPart1(e) : ConstructCSCPwdResetPart2(e);
            return e;
        }


        private string Stnd(int n)
        {
            return n == 1 ? "st" : "nd";

        }


        private string ConstructCSCPwdResetPart1(EmailInfo e)
        {

            e.Content.Body = null;


            e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Hello " + StringHelper.CapitalFirstChar(e.ManagerName) + ",<br><br>";
            // e.Content.Body += "<p style='margin-bottom:9.0pt'><b><span style='font-size:14.0pt;font-family:&quot;Arial&quot;,sans-serif'> A worker who reports to you<span style='color:black'>";
            e.Content.Body += " Your employee , <b> <strong> " + StringHelper.CapitalFirstChar(e.EmployeeName) + "</strong></b> has requested their L-CSC AD password to be reset.</span></b><b><span style = 'font-size:16.0pt;font-family:&quot;Arial&quot;,sans-serif' ></span></b></p>";
            //    e.Content.Body += "<p> <span style = 'font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'> You will need to provide a temporary password to <b><span style='color:red'>" + e.EmployeeName+"</b></span></p>";
            //    e.Content.Body += "<p><span style = 'font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif' ></span></p>";
            e.Content.Body += "<p><span style = 'font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif' > We will need you to communicate the password to your employee.";
            e.Content.Body += "<p> <span style = 'font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'>New password: <span style='color:red'>" + StringHelper.HTMLEscape(e.Key.Trim()) + "</b></span></p>";

            e.Content.Body += "<P><span>Thank you for your cooperation</span><span style = 'font-size:9.0pt;font-family:&quot;Arial&quot;,sans-serif'></p>";
            // e.Content.Body += "<p> <span style = 'font-size:9.0pt;font-family:&quot;Arial&quot;,sans-serif' >/span></p>";
            e.Content.Body += "<hr align='left';width='30%';COLOR='000000';size='2'><br>";
          //  e.Content.Body += "<p> <span style = 'font-size:9.0pt;font-family:&quot;Arial&quot;,sans-serif' >/span></p>";
            e.Content.Body += "<p> <b><span style = 'font-size:7.0pt;font-family:&quot;Arial&quot;,sans-serif;text-transform:uppercase' ></span></b></p>";
            e.Content.Body += "<span style = 'font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif;color:black' > Note: Please do not reply on this email, kindly reach us via chat/call DXC Support , if need be </span><b><span style = 'font-size:7.0pt;font-family:&quot;Arial&quot;,sans-serif;text-transform:uppercase'></span></b></p>";


            return e.Content.Body;
        }



        private string ConstructCSCPwdResetPart2(EmailInfo e)
        {
            // not longer used
            e.Content.Body = null;

            //e.Content.Body += "<HTML><BODY><img src='C:/Ext Proj/OneClick/Images/PWResetEmail1.JPG' Heigth='200' width='400'>";
            /*  e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Hello " + e.ManagerName + ",<br>";
              e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>Your employee <span style=''color:#FF0000''><b> " + e.EmployeeName + " </b> </span style=''color:#FF0000''> has requested their  Domain account password to be reset.<br>";
              e.Content.Body += "<br><p style='font-family:GT Walsheim Pro;font-size:11pt'>We will need you to communicate the password to your employee. The password will be sent in a separate email.<br>";
              e.Content.Body += "<hr align='left';width='50%';COLOR=' #5F249F';size='6'>";
              e.Content.Body += "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> Please do not reply on this email, kindly reach us via chat/call <a href='https://csc.service-now.com/selfservice/'> DXC Support </a>, if need be  </BODY></HTML> ";
            */


            e.Content.Body += "<p style='margin-bottom:9.0pt'><b><span style='font-size:14.0pt;font-family:&quot;Arial&quot;,sans-serif'>A worker who reports to you <span style='color:red'>";
            e.Content.Body += "</span> has requested a Universal ID password reset</span></b><span style='font-size:16.0pt;font-family:&quot;Arial&quot;,sans-serif'></span></p> ";
            e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'>A temporary password has been generated for " + StringHelper.CapitalFirstChar(e.EmployeeName ) ;

         
            // e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'><o:p>&nbsp;</o:p></span></p>:";
            e.Content.Body += "<p><b style='font-size:10.0pt; color :red ; font-family:&quot;Arial&quot;,sans-serif'>"+ StringHelper.HTMLEscape(e.Password) +"</b></p>";
            //e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'><o:p>&nbsp;</o:p></span></p>";
            e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'>Please provide this temporary password to the above mentioned worker.";
            //e.Content.Body += "<o:p></o:p></span></p>";
            //e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'><o:p>&nbsp;</o:p></span></p>";
            e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'>They<span style='color:red'>";
            e.Content.Body += "</span> can use this temporary password to log into <a href='https://nam12.safelinks.protection.outlook.com/?url=https%3A%2F%2Fidm.dxc.com%2Fcscidm%2FRedire action.jsf&amp;data=04%7C01%7C%7C5d2df49678b14320f57108d9df289e8a%7C93f33571550f43cfb09fcd331338d086%7C0%7C0%7C637786187821383382%7CUnknown%7CTWFpbGZsb3d8eyJWIjoiMC4wLjAwMDAiLCJQIjoiV2luMzIiLCJBTiI6Ik1haWwiLCJXVCI6Mn0%3D%7C3000&amp;sdata=pEse8J%2BBXjvXz5b9bPJIRE9ZD%2BovrgNrKJEJADHVA78%3D&amp;reserved=0' originalsrc='https://idm.dxc.com/cscidm/Redirection.jsf' shash='lnI0cUeLzNu3vFpyLJHuilRhIbPl2zSWFonEf24VVCs8yd9qa50Lt99R7cJaO6g0W42Do3w04z+Kc88J8qvalOrZFpRSB1PSSQS6JsMH2MrQZP41+p2PTAwATTyJDPC9gm1Q2Fl2vug0qg8tq4OA+FDE0X8PD6xSodl9XKBTy1A='> <br>";
            e.Content.Body += "<br>https://idm.dxc.com/cscidm/Redirection.jsf</a> to reset their password and set security questions for future password resets.&nbsp;";
            e.Content.Body += "</span><span style='font-family:&quot;Arial&quot;,sans-serif'></span></p>";
            e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'></span></p>";
            e.Content.Body += "<p><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'>More information on";
            e.Content.Body += "</span><span style='font-size:9.0pt;font-family:&quot;Arial&quot;,sans-serif'><a href='https://nam12.safelinks.protection.outlook.com/?url=https%3A%2F%2Fcsc.service-now.com%2Fsp%3Fid%3Dkb_article_view%26sys_kb_id%3D6be8d1e5dbfd1fc0f9dfcebe3b9619d2%26glide_sso_id%3D7b5e13254fb5d600a198a4eab110c723&amp;data=04%7C01%7C%7C5d2df49678b14320f57108d9df289e8a%7C93f33571550f43cfb09fcd331338d086%7C0%7C0%7C637786187821383382%7CUnknown%7CTWFpbGZsb3d8eyJWIjoiMC4wLjAwMDAiLCJQIjoiV2luMzIiLCJBTiI6Ik1haWwiLCJXVCI6Mn0%3D%7C3000&amp;sdata=x3zQq9a3fArz%2FzBxYpRuJb9fzi7UNmh32%2F%2BJM%2BXqESU%3D&amp;reserved=0' originalsrc='https://csc.service-now.com/sp?id=kb_article_view&amp;sys_kb_id=6be8d1e5dbfd1fc0f9dfcebe3b9619d2&amp;glide_sso_id=7b5e13254fb5d600a198a4eab110c723' shash='DlHfwuAQMXKMwD9UA5Q/GJY+g7j2bw86wgG2dREhggzY1VCTQIdIXS9OXpkL8h9xEnlpZQB/t9uLDo5/8s64tSHZ0KZMA+Ne2+gxn70JVFhTVPVU903fzwkR1kzAi6/CjmQFoNcz1rIt4b8o9N4ESPGdGqD2//9PrcyF1T2cJns='><b><span style='color:windowtext'> Universal ";

            e.Content.Body += "ID </span></b><b><span style='font-size:10.0pt;color:windowtext'>password reset process and policies</span></b></a></span><span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'> is available on ITConnect</span><span style='font-size:9.0pt;font-family:&quot;Arial&quot;,sans-serif'>.<o:p></o:p></span></p>";
            e.Content.Body += "<p><span style='font-size:9.0pt;font-family:&quot;Arial&quot;,sans-serif'></span></p>";
            e.Content.Body += "<span style='font-size:10.0pt;font-family:&quot;Arial&quot;,sans-serif'>Thank you for your cooperation.<o:p></o:p></span><p>";
            e.Content.Body += "<span style = 'font-size:8.0pt;font-family:&quot;Arial&quot;,sans-serif;color:black' > This email was sent from an unmonitored mailbox.Go to help.dxc.com for options on how to get IT help.</span>";
    



            return e.Content.Body;
        }


    }
}
