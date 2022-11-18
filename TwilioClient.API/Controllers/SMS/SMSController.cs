using Microsoft.AspNetCore.Mvc;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Controllers
{
    public class SMSController : ApiControllerBase
    {
        private readonly ISMSService _smsService;

        public SMSController(ISMSService smsService)
        {
            _smsService = smsService;
        }

        [HttpPost]
        public async Task<ActionResult> SendSMS(SMSModel smsModel)
        {
            // #TODO: Add auth service to authenticate calling app before saving sms
            await _smsService.SaveSMS(smsModel);
            return Ok();
        }
    }
}
