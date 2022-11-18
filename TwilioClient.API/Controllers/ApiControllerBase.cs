using Microsoft.AspNetCore.Mvc;

namespace TwilioClient.API
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/v1.1/[controller]")]
    public class ApiControllerBase : ControllerBase { }
}
