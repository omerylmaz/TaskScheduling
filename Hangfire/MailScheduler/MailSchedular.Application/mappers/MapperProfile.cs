using AutoMapper;
using MailSchedular.Application.Features.Commands.CreateProduct;
using MailSchedular.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Application.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateMailEventCommand, MailEvent>();
            //CreateMap<MailEvent, CreateMailEventCommandResponse>();
        }
    }
}
