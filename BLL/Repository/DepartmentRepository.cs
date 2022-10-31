using BLL.Interface;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DAL.Context;

namespace BLL.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DAL.Context.DbConnectionf context;  //create and assign field

        public DepartmentRepository(DAL.Context.DbConnectionf context )//run time create object take this refernce=>startup
        {
            this.context = context;
        }
        public  int Add (Department department)
        {
            context.Departments.Add(department);
            return context.SaveChanges();
           
        }

        public int Delete(Department department)
        {
             context.Departments.Remove(department);
            return context.SaveChanges();
        }

        public Department Get(int? id)=>
        
              context.Departments.FirstOrDefault(d=>d.Id==id);


        public IEnumerable<Department> GetAll()
       =>  context.Departments.ToList();

        public int Update(Department department)
        {
            context.Departments.Update(department);
            return context.SaveChanges();

        }

    
    }
}
