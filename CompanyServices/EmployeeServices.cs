using CompanyData;
using CompanyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyServices
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> CreateEmpolyee(Employee empolyee)
        {
            await _employeeRepository.AddAsync(empolyee);
            return empolyee;
        }

        public async Task<Employee> DeleteEmpolyee(Employee employee)
        {
            await _employeeRepository.DeleteAsync(employee);
            return employee;
        }

        public async Task<Employee> EditEmpolyee(Employee employee)
        {
            await _employeeRepository.UpdateAsync(employee);
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAllEmpolyee()
        {
            var employee = await _employeeRepository.GetAllAsync();
            return employee.OrderBy(g => g.LastName);
        }

        public async Task<Employee> GetEmployeeById(int? id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            return employee;
        }
    }
    
}
