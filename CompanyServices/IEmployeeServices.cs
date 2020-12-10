using CompanyModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyServices
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<Employee>> GetAllEmpolyee();
        Task<Employee> CreateEmpolyee(Employee empolyee);
        Task<Employee> GetEmployeeById(int? id);
        Task<Employee> EditEmpolyee(Employee empolyee);
        Task<Employee> DeleteEmpolyee(Employee empolyee);
    }
}
