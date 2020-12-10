using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyModel
{
    public class EmployeeTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
    }
}
