﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Website.Models
{
    public class Employee
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int ManagerID { get; set; }

    }
}