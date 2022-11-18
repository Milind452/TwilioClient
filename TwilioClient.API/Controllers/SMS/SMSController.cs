using Microsoft.AspNetCore.Mvc;

namespace TwilioClient.API.Controllers
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
