
using System.ComponentModel.DataAnnotations;

namespace WebAppSample.Helper
{
    public class CustomAttribute
    {
    }

    public class ValidateEmailDomainAttribute : ValidationAttribute
    {
        private readonly string _allowedDomain;
        public ValidateEmailDomainAttribute(string allowedDomain)
        {
            _allowedDomain = allowedDomain;
        }

        public override bool IsValid(object? value)
        {
            string[] strs = value.ToString().Split('@');
            return strs[0].ToUpper() == _allowedDomain.ToUpper();
        }
    }
}
