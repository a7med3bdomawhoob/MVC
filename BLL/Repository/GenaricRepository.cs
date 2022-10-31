using BLL.Interface;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{



    public class GenaricRepository<T>:IGenaricRepository<T> where T :class
    {


         private readonly DAL.Context.DbConnectionf context;  //create and assign field

    public GenaricRepository(DAL.Context.DbConnectionf context)//run time create object take this refernce=>startup
    {
        this.context = context;
    }


    public async Task< int> Add(T item)
        {
            context.Set<T>().Add(item);
            return await context.SaveChangesAsync();

        }

        public async Task< int> Delete(T item)
        {
            context.Set<T>().Remove(item);
            return await context.SaveChangesAsync();
        }

        public async Task< T> Get(int? id) =>

              //context.Set<T>().FirstOrDefault(d => d.Id == id);
            await  context.Set<T>().FindAsync(id);

        public async Task< IEnumerable<T>> GetAll()
        { 
            if(typeof(T)==typeof(Employee)) /*for Eager Loading for Employee*/
            {
                return  (IEnumerable<T>) await context.Set<Employee>().Include(E=>E.Department).ToListAsync();
            }
           return  await context.Set<T>().ToListAsync();
         }

        public async Task<int> Update(T item)
        {
            context.Set<T>().Update(item);
            return await context.SaveChangesAsync();

        }
    }
}
