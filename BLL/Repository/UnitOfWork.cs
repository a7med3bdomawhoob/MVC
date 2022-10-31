using BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public UnitOfWork(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            DepartmentRepository=departmentRepository;
            EmployeeRepository = employeeRepository;
        }
    }
}
