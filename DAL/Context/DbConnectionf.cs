using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DAL.Context
{
    public class DbConnectionf: IdentityDbContext<ApplicationUser>
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //     => optionsBuilder.UseSqlServer("Server=.,Database=mvcDatabase ,Integrated Security=true ,MultipleActiveResultSet=true");

        public DbConnectionf(DbContextOptions<DbConnectionf>options):base(options) 
        {
            //options from strtup options 
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}


//DAL for DB 