using FluentValidation;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Validators
{
    public class SMSModelValidator : AbstractValidator<SMSModel>
    {
        public SMSModelValidator()
        {
            RuleFor(m => m.AppName).NotEmpty().MaximumLength(100);
            RuleFor(m => m.AppToken).NotEmpty().MaximumLength(100);
            RuleFor(m => m.To).NotEmpty().MaximumLength(100);
            RuleFor(m => m.Body).NotEmpty();
        }
    }
}
