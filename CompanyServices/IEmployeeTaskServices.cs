using CompanyModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyServices
{
    public interface IEmployeeTaskServices
    {
        Task<IEnumerable<EmployeeTask>> GetAllEmpolyeeTask();
        Task<EmployeeTask> CreateEmpolyeeTask(EmployeeTask empolyeeTask);
        Task<EmployeeTask> GetEmployeeTaskById(int? id);
        Task<EmployeeTask> EditEmpolyeeTask(EmployeeTask empolyeeTask);
        Task<EmployeeTask> DeleteEmpolyeeTask(EmployeeTask empolyeeTask);
    }
}
