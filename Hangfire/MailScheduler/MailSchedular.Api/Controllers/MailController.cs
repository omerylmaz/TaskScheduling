using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using MailSchedular.Application.Features.Commands.CreateProduct;

namespace MailSchedular.Api.Controllers
{//https:/localhost:45120/api/mail/deneme
    [Route("api/mail")]
    [ApiController]
    public class MailController : ControllerBase
    {
        readonly IMediator _mediator;
        public MailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("mail-event")]
        public async Task<IActionResult> AddMailEvent(CreateMailEventCommand createMailEventCommand)
        {
            var response = _mediator.Send(createMailEventCommand);
            return Ok(response);
        }
    }
}
