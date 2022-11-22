using FluentValidation;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Validators
{
    public class EmailModelValidator : AbstractValidator<EmailModel>
    {
        public EmailModelValidator()
        {
            RuleFor(m => m.AppName).NotEmpty().MaximumLength(100);
            RuleFor(m => m.AppToken).NotEmpty().MaximumLength(100);
            RuleFor(m => m.From).NotEmpty().MaximumLength(100);
            RuleFor(m => m.To).NotEmpty().MaximumLength(100);
            RuleFor(m => m.Body).NotEmpty();
            RuleFor(m => m.Subject).NotEmpty();
        }
    }
}
