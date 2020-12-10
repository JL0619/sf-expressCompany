using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CompanyModel;

namespace CompanyData
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Empolyees { get; set; }
        public DbSet<EmployeeTask> EmpolyeeTasks { get; set; }
    }
}
