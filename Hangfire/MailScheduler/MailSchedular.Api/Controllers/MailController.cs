using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailSchedular.Api.Controllers
{//https:/localhost:45120/api/mail/deneme
    [Route("api/mail")]
    [ApiController]
    public class MailController : ControllerBase
    {
        [HttpPost("mail-event")]
        public async Task<IActionResult> AddMailEvent()
        {
            return Ok("ok");
        }
    }
}
