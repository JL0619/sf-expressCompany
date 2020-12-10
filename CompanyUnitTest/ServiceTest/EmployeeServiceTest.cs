using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyData;
using CompanyModel;
using CompanyServices;
using System.Collections.Generic;
using Moq;
using System;
using System.Linq;

namespace CompanyUnitTest
{
    [TestClass]
    public class EmployeeServiceTest
    {
        private IEmployeeServices _service;
        private Mock<IEmployeeRepository> _mockemployeeRepository;
        private List<Employee> _list;
        [TestInitialize]
        public void Initialize()
        {
            _mockemployeeRepository = new Mock<IEmployeeRepository>();
            _service = new EmployeeServices(_mockemployeeRepository.Object);
            _list = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "San",
                    LastName = "Zhang",
                    HireDate = DateTime.Parse("1989-2-12")
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Si",
                    LastName = "Li",
                    HireDate = DateTime.Parse("1999-2-12")
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Wei",
                    LastName = "Zhang",
                    HireDate = DateTime.Parse("2009-2-12")
                },
            };
            _mockemployeeRepository.Setup(d => d.GetEmployeeById(It.IsAny<int>())).ReturnsAsync((int s) => _list.First(x => x.Id == s));
        }
        [TestMethod]
        public async System.Threading.Tasks.Task CheckemployeeFromFakeDataAsync()
        {
            var employee = await _service.GetEmployeeById(1);
            Assert.AreEqual("San", employee.FirstName);
        }
    }
}
