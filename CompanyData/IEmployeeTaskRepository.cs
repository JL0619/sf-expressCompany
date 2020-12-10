using CompanyModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData
{
    public interface IEmployeeTaskRepository : IRepository<EmployeeTask>
    {
        Task<EmployeeTask> GetEmployeeTaskById(int? id);
    }
}
