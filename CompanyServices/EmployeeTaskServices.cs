using CompanyData;
using CompanyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyServices
{
    public class EmployeeTaskServices : IEmployeeTaskServices
    {
        private readonly IEmployeeTaskRepository _employeeTaskRepository;
        public EmployeeTaskServices(IEmployeeTaskRepository employeeTaskRepository)
        {
            _employeeTaskRepository = employeeTaskRepository;
        }
        public async Task<EmployeeTask> CreateEmpolyeeTask(EmployeeTask empolyeeTask)
        {
            await _employeeTaskRepository.AddAsync(empolyeeTask);
            return empolyeeTask;
        }

        public async Task<EmployeeTask> DeleteEmpolyeeTask(EmployeeTask empolyeeTask)
        {
            await _employeeTaskRepository.DeleteAsync(empolyeeTask);
            return empolyeeTask;
        }

        public async Task<EmployeeTask> EditEmpolyeeTask(EmployeeTask employeeTask)
        {
            await _employeeTaskRepository.UpdateAsync(employeeTask);
            return employeeTask;
        }

        public async Task<IEnumerable<EmployeeTask>> GetAllEmpolyeeTask()
        {
            var employeeTask = await _employeeTaskRepository.GetAllAsync();
            return employeeTask.OrderBy(g => g.TaskName);
        }

        public async Task<EmployeeTask> GetEmployeeTaskById(int? id)
        {
            var employeeTask = await _employeeTaskRepository.GetEmployeeTaskById(id);
            return employeeTask;
        }
    }

}
