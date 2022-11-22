using Microsoft.AspNetCore.Mvc;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Controllers
{
    public class EmailController : ApiControllerBase
    {
        private readonly IAuthService _authService;

        public EmailController(IAuthService authService)
        {
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

            //#TODO: Call emailService to save incoming email
            return Ok();
        }
    }
}
