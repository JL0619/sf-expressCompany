using CompanyData;
using CompanyModel;
using CompanyServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyUnitTest.ServiceTest
{
    [TestClass]
    public class EmpolyeeTaskServiceTest
    {
        private IEmployeeTaskServices _service;
        private Mock<IEmployeeTaskRepository> _mockemployeeTaskRepository;
        private List<EmployeeTask> _list;
        [TestInitialize]
        public void Initialize()
        {
            _mockemployeeTaskRepository = new Mock<IEmployeeTaskRepository>();
            _service = new EmployeeTaskServices(_mockemployeeTaskRepository.Object);
            _list = new List<EmployeeTask>
            {
                new EmployeeTask
                {
                    Id = 1,
                    TaskName = "A",
                    StartDate = DateTime.Parse("1989-2-12"),
                    Deadline = DateTime.Parse("1989-2-13")
                },
                new EmployeeTask
                {
                    Id = 2,
                    TaskName = "B",
                    StartDate = DateTime.Parse("1989-2-12"),
                    Deadline = DateTime.Parse("1989-2-16")
                },
                new EmployeeTask
                {
                    Id = 3,
                    TaskName = "C",
                    StartDate = DateTime.Parse("1989-2-12"),
                    Deadline = DateTime.Parse("1989-2-20")
                },
            };
            _mockemployeeTaskRepository.Setup(d => d.GetEmployeeTaskById(It.IsAny<int>())).ReturnsAsync((int s) => _list.First(x => x.Id == s));
        }
            [TestMethod]
            public async System.Threading.Tasks.Task CheckemployeeTaskFromFakeDataAsync()
            {
                var employeeTask = await _service.GetEmployeeTaskById(1);
                Assert.AreEqual("A", employeeTask.TaskName);
            }
        }
    
}
