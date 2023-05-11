using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IApplicationBuilder app)
        {
            services.AddHangfire(configuration => {
                configuration.UseSqlServerStorage("Data Source=DESKTOP-8RL8JOG;Initial Catalog=hangfire;Integrated Security=True;Pooling=False");
            });
            services.AddHangfireServer();

            app.UseHangfireDashboard();
        }
    }
}
