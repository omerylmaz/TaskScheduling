using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Persistence.Contexts
{
    public class SchedularDbContext : DbContext
    {
        public SchedularDbContext(DbContextOptions<SchedularDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
