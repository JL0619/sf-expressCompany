using CompanyModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CompanyDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Employee> GetEmployeeById(int? id)
        {
            var employee = await _dbContext.Empolyees.FirstOrDefaultAsync(u => u.Id == id);
            return employee;
        }
    }
}
