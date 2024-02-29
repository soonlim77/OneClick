using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Logic.Interface;
//using Logic.Factory;
//using Logic.Model;
//using Logic.Interface.Validator;
//using Logic.Facade;
//using Logic.Global;
//using Logic.Interface.Implementation;
//using Logic.Invoker;

using OneClick.Interface;
using OneClick.Factory;
using OneClick.Model;
using OneClick.Interface.Validator;
using OneClick.Facade;
using OneClick.Global;
using OneClick.Interface.Implementation;
using OneClick.Invoker;

namespace OneClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btnComposeEmail_Click(object sender, EventArgs e)
        {
            if (!CheckOneTemplate())
                MessageBox.Show("Choose one template");
            else
            {
             

                //Get radiobutton text 
                GlobalVariable.rbselection = GetSelection();

            
                IResult result1 = Processor.ValidateEmail(txtTo.Text);
                IResult result2 = Processor.ValidateEmail(txtCC.Text);

                if (!result1.IsSuccess && !result2.IsSuccess)
                {
                    MessageBox.Show(result1.Message, "Error");

                }
                else
                {
                    EmailInfo info = GetEmailObject();
                    IComposeEmail templateobj = TemplateFactory.GetTemplateOption(GlobalVariable.rbselection);
                    templateobj.ComposeEmail(info);

                }

                this.Close();
            }

            
        }


        private void SEbtnCompose_Click(object sender, EventArgs e)
        {


            GlobalVariable.rbSEchoice = SEGetSelection();
            //      MessageBox.Show("HELLO " + GlobalVariable.rbSEchoice);

            IResult retTo = new EmailValidator().Validate(SEtxtTo.Text);
            IResult retCC = new EmailValidator().Validate(SEtxtCC.Text);

            if (!retTo.IsSuccess && !retCC.IsSuccess)
            {
                MessageBox.Show(retTo.Message,"error");

            }
            else
            {
                EmailInfo SEef = SEGetEmailObject();
                IComposeEmail seObj = TemplateFactory.SEGetTemplateOption(GlobalVariable.rbSEchoice);

                seObj.ComposeEmail(SEef);


            }

            this.Close();



        }


        private EmailInfo GetEmailObject()
        {
            var email = new NonStrikeEmailInfo(txtTo.Text, txtCC.Text, txtManagerName.Text, txtEmployeeName.Text,
                                      txtKey.Text, txtTicketNumber.Text);

                           return (EmailInfo) email;
                    
        }

        private EmailInfo SEGetEmailObject()
        {
            var email = new StrikeEmailInfo(SEtxtTo.Text, SEtxtCC.Text,  SEtxtEmployeeName.Text, SEtxtTicket.Text, SEtxtIssue.Text);

            return (EmailInfo)email;

        }


        private bool CheckOneTemplate()
        {

            bool ret = true;

            if ((rbUniversalID.Checked == false) && (rbDomainPwdReset.Checked == false)
                && (rbBitLocker.Checked == false) && (rbMainFrame.Checked == false))
                ret = false;


            return ret;


        }

        private string GetSelection()
        {
              string text=null;

            if (this.rbUniversalID.Checked)
                text = rbUniversalID.Text.Trim();
            if (this.rbDomainPwdReset.Checked)
                text = rbDomainPwdReset.Text.Trim();
            if (this.rbBitLocker.Checked)
                text = rbBitLocker.Text.Trim();
            if (this.rbMainFrame.Checked)
                text = rbMainFrame.Text.Trim();

             return text.ToString();
        }      

                 

        private string SEGetSelection()
        {
            string text = null;

            if (this.rbStrike1.Checked)
                text = rbStrike1.Text;
            if (this.rbStrike2.Checked)
                text = rbStrike2.Text;
            if (this.rbStrike3.Checked)
                text = rbStrike3.Text;
          
            return text.ToString();
        }

        private void btnCSCCompose_Click(object sender, EventArgs e)
        {


            IResult retTo = new EmailValidator().Validate(txtCSCTo.Text);
            IResult retCC = new EmailValidator().Validate(txtCC.Text);

            if (!retTo.IsSuccess && !retCC.IsSuccess)
            {
                MessageBox.Show(retTo.Message, "error");

            }
            else
            {

                IResult resName = new StringValidator().Validate(txtCSCName.Text);
                IResult resPwd = new StringValidator().Validate(txtCSCPassword.Text);

                if (!resName.IsSuccess || !resPwd.IsSuccess)
                    MessageBox.Show(resName.Message, "Empty field");
                else
                {
                    // using invoker pattern to move compose logic to 2nd layer
                    // client has no idea what email type to be composed
                    EmailInfo CSCef = CSCGetEmailObject();
                    IComposeEmail CSCobj = new CSCPwdReset();

                    var invoker = new EmailInvoker(CSCobj);
                    invoker.ComposeEmail(CSCef);
                }
                //CSCobj.ComposeEmail(CSCef);
            }
            this.Close();
        }


        private EmailInfo CSCGetEmailObject()
        {          
                var email = new NonStrikeEmailInfo(txtCSCTo.Text, txtCSCCC.Text,  txtCSCManager.Text.Trim(),txtCSCName.Text, txtCSCPassword.Text.Trim(),string.Empty);
                return (EmailInfo)email;

        }
    }

}
