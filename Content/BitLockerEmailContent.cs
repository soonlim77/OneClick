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
    public class BitLockerEmailContent : IEmailContent
    {

        public PictureBox Logo { get; set; }
        public string Subject { get; set; }
      


        public EmailInfo ConstructBody(EmailInfo e, int part)
        {
            e.Content = new EmailContent("Urgent Action Required: BitLocker Encryption Recovery for ticket " + e.Ticket);
            e.Content.Body = ConstructBitLoker(e);
            return e;
        }



        private string ConstructBitLoker(EmailInfo e)
        {

            e.Content.Body = null;
          

          // "<BODY><IMG src="'cid:BitLockerheading.JPG'" width=530> </BODY>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'>Hello " + StringHelper.CapitalFirstChar(e.ManagerName) +",<br>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'>Your employee <span style='color:#FF0000'><b> " + StringHelper.CapitalFirstChar(e.EmployeeName)+ " </b> </span style='color:#FF0000'> has requested a BitLocker encryption recovery key.<br>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'>This key is required to start your employee's computer.<br>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'>Please communicate the following instructions to your employee:<br>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'>If you have any questions, kindly reach us via chat/call <a href='https://csc.service-now.com/selfservice/'> DXC Support </a>.<br>" ;
                 e.Content.Body+= "<hr align='left';width='50%';COLOR='000000';size='6'>" ;
                 e.Content.Body+= "<p style='font-family:Calibri (Body);font-size:12pt'><b>Instructions:</b>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'><b>Step 1: </b>Follow these instructions to perform BitLocker encryption recovery on your device:<br>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'><ol><li>At the BitLocker Recovery screen enter this 48-character recovery key.</li>" ;
                 e.Content.Body+= "<B><p style='font-family:calibri;font-size:16pt'><span style='color:#FF0000'><b>"+ StringHelper.HTMLEscape(e.Key)+" </b> </span style='color:#FF0000'></B>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'><b>Note: </b>You can use the number keys or function keys F1-F10 (Use F10 for 0) to input numbers.<br>" ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'>If you have an issue where letters on a laptop keyboard appear as numbers you may have Numlock enabled on your machine, simply turn Numlock off and try again." ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'><li>Press Enter when done.</ol></li>" ;
                 e.Content.Body+= "<p style='font-family:Calibri (Body);font-size:12pt'><b>Step 2: </b>After you log on to your computer reset BitLocker encryption." ;
                 e.Content.Body+= "<br><p style='font-family:Calibri (Body);font-size:12pt'><ul><li><b>Windows 7: </b>Go to Control Panel, System and Security, <b>BitLocker Drive Encryption</b><br></li>" ;
                 e.Content.Body+= "<p style='font-family:Calibri (Body);font-size:12pt'><li><b>Windows 10: </b>Go to Control Panel and then select, <b>BitLocker Drive Encryption</b></li>" ;
                 e.Content.Body+= "<p style='font-family:Calibri (Body);font-size:12pt'>Select the option to <b>Suspend Protection</b> on the PC COE Drive, then <b>Resume Protection</b>.<br>" ;
                 e.Content.Body+= "<p style='font-family:Calibri (Body);font-size:12pt'><b>Note: </b>If you do not see the option to <b>Suspend Protection</b> your computer is still encrypting. Wait for it to finish before rebooting your computer.</ul>" ;
                 e.Content.Body+= "<BODY><center><IMG src='cid:BitLocker.JPG' width=600 height=500> </center></BODY>" ;
                 e.Content.Body+= "<hr align='left';width='50%';COLOR='000000';size='6'>" ;
                 e.Content.Body+= "<p style='font-family:GT Walsheim Pro;font-size:11pt'><b>Note:</b> Please do not reply on this email, kindly reach us via chat/call <a href='https://uptime.dxc.com/ '> DXC Support </a>, if need be";



            return e.Content.Body;
        }

    }
}
