using Microsoft.AspNetCore.Mvc;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.API.Controllers
{
    public class RegisterAppController : ApiControllerBase
    {
        private readonly IRegisterAppService _registerAppService;

        public RegisterAppController(IRegisterAppService registerAppService)
        {
            _registerAppService = registerAppService;
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterAppModel app)
        {
            await _registerAppService.SaveApp(app);
            return Ok();
        }
    }
}
