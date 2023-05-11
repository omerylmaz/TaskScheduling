using AutoMapper;
using MailSchedular.Application.Interfaces.Repositories;
using MailSchedular.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Application.Features.Commands.CreateProduct
{
    public class CreateMailEventCommandHandler : IRequestHandler<CreateMailEventCommand, bool>
    {
        private readonly IMailEventRepository _mailEventRepository;
        private readonly IMapper _mapper;
        public CreateMailEventCommandHandler(IMailEventRepository mailEventRepository, IMapper mapper)
        {
            _mailEventRepository = mailEventRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateMailEventCommand request, CancellationToken cancellationToken)
        {
            var mailEvent = _mapper.Map<MailEvent>(request);
            var response = await _mailEventRepository.AddAsync(mailEvent);
            return response;
        }
    }
}
