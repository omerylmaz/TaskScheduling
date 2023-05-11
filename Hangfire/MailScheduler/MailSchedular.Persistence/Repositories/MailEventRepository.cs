using MailSchedular.Application.Interfaces.Repositories;
using MailSchedular.Domain.Entities;
using MailSchedular.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Persistence.Repositories
{
    public class MailEventRepository : GenericRepository<MailEvent>, IMailEventRepository
    {
        public MailEventRepository(SchedularDbContext dbContext) : base(dbContext)
        {
        }
    }
}
