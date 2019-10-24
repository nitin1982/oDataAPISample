using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagementAPI.Controllers
{
    public class DepartmentsController : ApiController
    {
        private EmployeeManagementDbContext dbcontext;
        public DepartmentsController()
        {
            dbcontext = new EmployeeManagementDbContext();
        }
        // GET api/values
        public IEnumerable<Department> Get()
        {
            return dbcontext.Departments.ToList();
        }

        
    }
}
