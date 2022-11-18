using Microsoft.AspNetCore.Mvc;

namespace TwilioClient.API
{
    public class SMSController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> SendSMS()
        {
            return Ok();
        }
    }
}
