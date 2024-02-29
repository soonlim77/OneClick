using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneClick.Model
{
    public class EmailContent
    {

       
        public string Subject { get; set; }
        public string Body { get; set; }
        //public int Part { get; set; }

        public EmailContent()
        {

        }

        public EmailContent(string subject )
        {
          
             this.Subject = subject;
            //this.Body = part == 1 ? "Universal ID Compose part 1" : "Universal ID Compose part 2";


        }


    



    }
}
