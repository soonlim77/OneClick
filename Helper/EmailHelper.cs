using Microsoft.Office.Interop.Outlook;
using OneClick.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneClick.Global;
using System.IO;







namespace OneClick.Helper
{
    public class EmailHelper
    {
        private static EmailHelper instance = null;
        public  string imageSrc { get; set; }
        public string imagePath { get; set; }
        

        private EmailHelper()
        {

        }

        // singleton instance to limit one object

        public static EmailHelper GetInstance()
        {
            //Ensure ONE instance of class type

            if (instance == null)
                instance = new EmailHelper();

            return instance;


        }


        public void CreateOutlookEmail(EmailInfo ef, string imgName)
        {
            // imagePath = @"C:\Ext Proj\OneClick\Images\";

            try
            {

                /*
                 The following code determine which path to be used in images in debug & release mode
                  Debug =@"C:\Ext Proj\OneClick\Images\";
                  Release  @"C:\Ext Proj\OneClick\bin\release\";
                 
                 */
                imagePath = AppDomain.CurrentDomain.BaseDirectory;

                if (System.Diagnostics.Debugger.IsAttached)
                {
                  //  imagePath = AppDomain.CurrentDomain.BaseDirectory;
                    imagePath = Path.GetFullPath(Path.Combine(imagePath, @"..\..\"));
                    imagePath = imagePath + @"Images\";
                    imageSrc = imagePath + imgName;
                }
                else
                {
                    imageSrc = imagePath + imgName;
                   // imageSrc = imgName;
                }


                    CreateMailItem(ef, imgName);

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
             
                
        }

        private void CreateMailItem(EmailInfo ef, string imgName)
        {
       //   long prop = Convert.ToInt64(mailItem.PropertyAccessor.GetProperty(PR_SECURITY_FLAGS));
            var ulFlags = 0x0;
            ulFlags = (ulFlags |0x1); //  SECFLAG_ENCRYPTED
                                       //ulFlags = (ulFlags | 0x2); //  SECFLAG_SIGNED

            Application outlookApp = new Application();

            MailItem mailItem = (MailItem)outlookApp.CreateItem(OlItemType.olMailItem);


            if (imageSrc != null)
                AddAttachment(mailItem);

            //  string myident = imgName;
            //     attachment.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x3712001F", "myident");


            mailItem.SentOnBehalfOfName = ef.From;// ConfigurationManager.AppSettings.Get("CommonSender");

            //  mailItem.Sender.GetExchangeUser.PrimarySmtpAddress = "Soonlim@gmail.com";
            if (ef.EmailGroup!=2)
                 mailItem.Permission = OlPermission.olDoNotForward;

            mailItem.Subject = ef.Content.Subject;
            mailItem.To = ef.To;
           // mailItem.BCC = ConfigurationManager.AppSettings.Get("BCC");
            mailItem.CC = ef.CC;// ConfigurationManager.AppSettings.Get("DscService"); 
            mailItem.HTMLBody = imgName == null ? ef.Content.Body : string.Format("<HTML> <BODY><img src=\'cid:{0}\'> </BODY></HTML>", imgName) + ef.Content.Body;
            mailItem.Importance = OlImportance.olImportanceHigh;
            mailItem.Display(false);

            //    mailItem.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/id/{0006200\8-0000-0000-C000-000000000046}/8514000B", true);
        }


        private Attachment AddAttachment(MailItem mailItem)
        {
            
                var attachments = mailItem.Attachments;
                var attachment = attachments.Add(imageSrc, OlAttachmentType.olEmbeddeditem, null, "Attach non-BitLocker image to attachment");


                if(GlobalVariable.rbselection == "Bit-Locker")
                      attachments.Add(imagePath + "BitLocker.jpg",OlAttachmentType.olEmbeddeditem, null, "Locker Image to display");

         //       attachment.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x3712001F", "imgName");
            return attachment;
               
        }

        
        // for strike email use
        public void CreateOutlookEmail(EmailInfo ef)
        {

            CreateMailItem(ef, null);
        }
    }
}
