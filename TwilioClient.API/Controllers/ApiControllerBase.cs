using Microsoft.AspNetCore.Mvc;

namespace TwilioClient.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/v1.1/[controller]")]
    public class ApiControllerBase : ControllerBase { }
}
