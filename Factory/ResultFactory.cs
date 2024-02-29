using OneClick.Interface;
using OneClick.Interface.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Factory
{
    public class ResultFactory
    {

        public static IResult GetSuccessResultInstance()
        {
            return new GenericResult(true);
        }

        public static IResult GetSuccessWithMessageResultInstance(string msg)
        {
            return new GenericResult(true, msg);

        }

        public static IResult GetFailResultInstance(string message)
        {
            return new GenericResult(false, message);
        }
    }
}
