using FluentValidation;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Validators
{
    public class RegisterAppModelValidator : AbstractValidator<RegisterAppModel>
    {
        public RegisterAppModelValidator()
        {
            RuleFor(m => m.AppName).NotEmpty().MaximumLength(100);
            RuleFor(m => m.AppToken).NotEmpty().MaximumLength(100);
            RuleFor(m => m.TwilioSID).NotEmpty().MaximumLength(100);
            RuleFor(m => m.TwilioToken).NotEmpty().MaximumLength(100);
        }
    }
}
