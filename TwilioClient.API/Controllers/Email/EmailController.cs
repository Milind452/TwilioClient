using Microsoft.AspNetCore.Mvc;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Controllers
{
    public class EmailController : ApiControllerBase
    {
        private readonly IEmailService _emailService;

        private readonly IAuthService _authService;

        public EmailController(
            IEmailService emailService,
            IAuthService authService
        )
        {
            _emailService = emailService;
            _authService = authService;
        }

        [HttpPost]
        public async Task<ActionResult> SendSMS(EmailModel emailModel)
        {
            var response =
                await _authService
                    .AuthorizeApp(emailModel.AppName, emailModel.AppToken);
            if (!response.IsSuccessful)
            {
                return Unauthorized(response.Message);
            }

            await _emailService.SaveEmail(emailModel);
            return Ok();
        }
    }
}
