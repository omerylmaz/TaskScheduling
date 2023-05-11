using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Application.Features.Commands.CreateProduct
{
    public class CreateMailEventCommand : IRequest<bool>
    {
        public string ToMail { get; set; }
        public string Message { get; set; }
    }
}
