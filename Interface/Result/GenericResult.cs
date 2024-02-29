using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Interface.Result
{
    public class GenericResult:IResult
    {

        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public GenericResult(bool value)
        {
            IsSuccess = value;
        }

        public GenericResult(bool value, string msg)
        {
            IsSuccess = value;
            Message = msg;
        }


        
    }
}
