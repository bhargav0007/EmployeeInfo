using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeeAccessor.Models
{
    [Table("Emp")]
    public class Employee
    {
        [Column("empno")]
        [Key]
        public int EmpNo { get; set; }

        [Column("ename")]
        public string EmpName { get; set; }

        [Column("job")]
        public string Job { get; set; }

        [Column("mgr")]
        public int? Mgr { get; set; }

        [Column("hiredate")]
        public DateTime HireDate { get; set; }

        [Column("sal")]
        public decimal? Sal { get; set; }

        [Column("comm")]
        public decimal? Comm { get; set; }

        [Column("dept")]
        public int Dept { get; set; }
    }
}
