using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OneClick.Helper
{
    public class StringHelper
    {
        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public static string HTMLEscape(string password)
        {

             password=password.Replace("<", "&lt;").Replace(">", "&gt;").Trim();
            return password;
          //      Replace("&", "&amp;").Replace("'", "&quot;").Replace(" ", "&nbsp;");
       

        }

        public static string CapitalFirstChar(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1);

        }
    }
}
