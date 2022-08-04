using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DummyMVC.Data;

namespace DummyMVC.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public Nullable<decimal> EmpSalary { get; set; }
        public string Job { get; set; }

    }
}