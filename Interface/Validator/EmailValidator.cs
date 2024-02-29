using OneClick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using OneClick.Factory;

namespace OneClick.Interface.Validator
{
    public class EmailValidator : IValidator<string, IResult>
    {
        IResult ret = null;
        public IResult Validate(string input)
        {
           

            string pattern = @"(@)(.+)$";
            if (Regex.Match(input, pattern).Success)
             {
              ret= ResultFactory.GetSuccessResultInstance(); 
             }
             else
              ret= ResultFactory.GetFailResultInstance("Invalid email format");


            return ret;

        }
    }
}
