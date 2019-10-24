using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string City { get; set; }

        [ForeignKey("EmployeeDepartment")]
        public int DepartmentId { get; set; }
        public virtual Department EmployeeDepartment { get; set; }
    }
}
