using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module4HW3.Data.EntityConfigurations;

namespace Module4HW3.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            builder.ApplyConfiguration(new EmployeeProjectEntityTypeConfiguration());
            builder.ApplyConfiguration(new OfficeEntityTypeConfiguration());
            builder.ApplyConfiguration(new ProjectEntityTypeConfiguration());
            builder.ApplyConfiguration(new TitleEntityTypeConfiguration());
        }
    }
}
