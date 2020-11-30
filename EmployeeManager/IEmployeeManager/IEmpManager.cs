using EmployeeManager.ViewModals;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager.IEmployeeManager
{
   public interface IEmpManager
    {
        List<EmployeeViewModal> getEmployeeView();
    }
}
