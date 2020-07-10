using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.CustomValidation
{
    public class EmailValidation :ValidationAttribute
    {
        private readonly string _allowedDomain;
        public EmailValidation(string allowedDomain)
        {
            _allowedDomain = allowedDomain;
        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');

            if (email[1].ToUpper()==_allowedDomain.ToUpper())
                return true;
            return false;
         
        }
    }
}
