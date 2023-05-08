using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailSchedular.Api.Controllers
{//https:/localhost:45120/api/mail/deneme
    [Route("api/mail")]
    [ApiController]
    public class MailController : ControllerBase
    {
        [HttpGet("deneme")]
        public async Task<IActionResult> deneme()
        {
            return Ok("ok");
        }
    }
}
