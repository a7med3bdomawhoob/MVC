
using BLL.Interface;
using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Repository
{
    public class EmployeeRepository : GenaricRepository<Employee> /*inhiritance*/   , IEmployeeRepository
    {
        private readonly DbConnectionf context;

        public EmployeeRepository(DbConnectionf context) :base(context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> getEmployeeByDepartmentName()
        {
            throw new NotImplementedException();
        }

        public async Task< IEnumerable<Employee>> Search(string value)
          => await context.Employees.Where(E => E.Name.Contains(value)).ToListAsync();  

      
    }
}
