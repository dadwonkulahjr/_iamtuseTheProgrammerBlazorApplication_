using System.ComponentModel.DataAnnotations;

namespace tuseTheProgrammerBlazor.Models.CustomValidator
{
    public class EmailValidator : ValidationAttribute
    {
        public string AllowEmailDomain { get; set; }
        public EmailValidator(string allowEmailDomain)
        {
            AllowEmailDomain = allowEmailDomain;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string[] convertEmail = value.ToString().Split('@');
                if (convertEmail.Length > 1 && convertEmail[1].ToUpper() == AllowEmailDomain.ToUpper())
                {
                    return null;
                }
                else
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return null;

        }
    }
}
