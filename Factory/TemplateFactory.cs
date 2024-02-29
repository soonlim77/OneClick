using OneClick.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneClick.Interface.Implementation;
using OneClick.Model;
using OneClick.Content;

namespace OneClick.Factory
{
   public static  class TemplateFactory
    {
        private static IComposeEmail obj =null;

        public static IComposeEmail GetTemplateOption(string text)
        {

             switch (text.Trim())
            {
                

                case "Universal ID": obj= new UniversalID();
                                break;

                case "Bit-Locker": obj=new BitLocker();
                                  break;

                case "Domain Password Reset": obj = new DomainPwdReset();
                    break;

                case "MainFrame": obj = new MainFrame();
                    break;

                default: 
                    break;
            }
            return  obj;
        }


        public static IEmailContent GetEmailOption(string text)
        {
            IEmailContent obj = null;

            switch (text.Trim())
            {


                case "Universal ID":
                    obj = new UniversalEmailContent();
                    break;

                case "Bit-Locker":
                    obj = new BitLockerEmailContent();
                    break;

                case "Domain Password Reset":
                    obj = new DomainPwdResetEmailContent();
                    break;

                case "MainFrame":
                    obj = new MainFrameEmailContent();
                    break;

                default:
                    break;
            }
            return obj;
        }



        public static IComposeEmail SEGetTemplateOption(string seChoice)
        {
            IComposeEmail obj=null;


            switch (seChoice.Trim())
            {                

                case "Strike 1":
                    obj = new StrikeOne();
                    break;

                case "Strike 2":
                    obj = new StrikeTwo();
                    break; 

                case "Strike 3":
                    obj = new StrikeThree();
                    break;
                                   
                default:
                    break;
            }
            return obj;



        }

        public static IEmailContent GetSEEmailOption(string text)
        {
            IEmailContent seobj = null;

            switch (text.Trim())
            {

                case "Strike 1":
                    seobj = new SE1EmailContent();
                    break;

                case "Strike 2":
                    seobj = new SE2EmailContent();
                    break;

                case "Strike 3":
                    seobj = new SE3EmailContent();
                    break;

           

                default:
                    break;
            }
            return seobj;
        }

    }

}

