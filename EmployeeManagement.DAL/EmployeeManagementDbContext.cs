using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class EmployeeManagementDbContext: DbContext
    {
        public EmployeeManagementDbContext():base()
        {
            this.Database.Connection.ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=EmployeeManagementDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
