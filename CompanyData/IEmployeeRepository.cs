using CompanyModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Employee> GetEmployeeById(int? id);
    }
}
