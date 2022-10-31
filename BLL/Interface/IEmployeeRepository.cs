using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public  interface IEmployeeRepository:IGenaricRepository<Employee>
    {
        public IEnumerable<Employee> getEmployeeByDepartmentName();
        public Task< IEnumerable<Employee>> Search(string value);
    }


}
