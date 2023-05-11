using MailSchedular.Application.Interfaces.Repositories;
using MailSchedular.Persistence.Contexts;
using MailSchedular.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SchedularDbContext>(options =>
                options.UseInMemoryDatabase(configuration.GetConnectionString(configuration.GetConnectionString("InMemory"))));
            services.AddScoped<IMailEventRepository, MailEventRepository>();
        }
    }
}
