using EmployeeAccessor.IAccessor;
using EmployeeAccessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAccessor
{
    public class EmpAccessor : IEmpAccessor
    {
        private readonly EmployeeContext _employeeContext;

        public EmpAccessor(EmployeeContext employeeContext)
        {
            this._employeeContext = employeeContext;
        }
        public List<Employee> GetEmployees()
        {
            var empInfo = _employeeContext.Employees.ToList();
            return empInfo;
        }
    }
}
