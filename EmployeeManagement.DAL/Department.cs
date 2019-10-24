using System.Collections.Generic;

namespace EmployeeManagement.DAL
{
    public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public  virtual ICollection<Employee> Employees { get; set; }
    }
}