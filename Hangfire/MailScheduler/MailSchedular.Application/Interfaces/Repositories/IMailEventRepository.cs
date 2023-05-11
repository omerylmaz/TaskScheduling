using MailSchedular.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Application.Interfaces.Repositories
{
    public interface IMailEventRepository : IGenericRepository<MailEvent>
    {
    }
}
