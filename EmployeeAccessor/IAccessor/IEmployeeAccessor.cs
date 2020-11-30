using EmployeeAccessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAccessor.IAccessor
{
    public interface IEmpAccessor
    {
        List<Employee> GetEmployees();
    }
}
