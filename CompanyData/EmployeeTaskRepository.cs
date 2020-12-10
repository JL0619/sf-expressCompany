using CompanyModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData
{
    public class EmployeeTaskRepository : Repository<EmployeeTask>, IEmployeeTaskRepository
    {
        public EmployeeTaskRepository(CompanyDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<EmployeeTask> GetEmployeeTaskById(int? id)
        {
            var employeeTask = await _dbContext.EmpolyeeTasks.FirstOrDefaultAsync(u => u.Id == id);
            return employeeTask;
        }
    }
}
