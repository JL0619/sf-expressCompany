using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyModel
{
    public class EmployeeTasks
    {
        public int EmployeeId { get; set; }
        public int EmpolyeeTaskId { get; set; }
        public virtual Employee Empolyee { get; set; }
        public virtual EmployeeTask EmployeeTask { get; set; }
    }
}
