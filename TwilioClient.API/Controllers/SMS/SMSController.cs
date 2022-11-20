using Microsoft.AspNetCore.Mvc;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Controllers
{
    public class SMSController : ApiControllerBase
    {
        private readonly ISMSService _smsService;

        private readonly IAuthService _authService;

        public SMSController(ISMSService smsService, IAuthService authService)
        {
            _smsService = smsService;
            _authService = authService;
        }

        [HttpPost]
        public async Task<ActionResult> SendSMS(SMSModel smsModel)
        {
            var response =
                await _authService
                    .AuthorizeApp(smsModel.AppName, smsModel.AppToken);
            if (!response.IsSuccessful)
            {
                return Unauthorized(response.Message);
            }

            await _smsService.SaveSMS(smsModel);
            return Ok();
        }
    }
}
