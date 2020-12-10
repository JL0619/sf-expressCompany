﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyModel
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<EmployeeTask> Task { get; set; }
    }
}
