using System;

namespace EmployeeManager.ViewModals
{
    public class EmployeeViewModal
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public string Job { get; set; }

        public int? Mgr { get; set; }
        public DateTime HireDate { get; set; }

        public int Sal { get; set; }

        public int? Comm { get; set; }

        public int Dept { get; set; }
    }
}
