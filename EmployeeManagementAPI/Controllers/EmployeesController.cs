using EmployeeManagement.DAL;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagementAPI.Controllers
{
    public class EmployeesController : ODataController
    {
        private EmployeeManagementDbContext dbcontext;
        public EmployeesController()
        {
            dbcontext = new EmployeeManagementDbContext();
        }
        private bool EmployeeExists(int key)
        {
            return dbcontext.Employees.Any(p => p.EmployeeID == key);
        }

        // GET api/values
       

        [EnableQuery]
        public IQueryable<Employee> Get()
        {
            return dbcontext.Employees;
        }
        [EnableQuery]
        public SingleResult<Employee> Get([FromODataUri] int key)
        {
            IQueryable<Employee> result = dbcontext.Employees.Where(p => p.EmployeeID == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            dbcontext.Dispose();
            base.Dispose(disposing);
        }
    }
}
