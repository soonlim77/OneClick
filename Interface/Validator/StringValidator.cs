using OneClick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneClick.Factory;

namespace OneClick.Interface.Validator
{
    public class StringValidator : IValidator<string, IResult>
    {

        IResult ret = null;
        public IResult Validate(string input)
        {

            if (input!=string.Empty)
            {
                ret = ResultFactory.GetSuccessResultInstance();
            }
            else
                ret = ResultFactory.GetFailResultInstance("* The field is mandatory to fill");


            return ret;

        }
    }
}
