using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Interface
{
    public interface IDepartmentRepository
    {
        Department Get(int? id);
       IEnumerable <Department>GetAll();//IEnemurable parent of all Collection 
      int Update(Department department);

       int  Add(Department department);
        int Delete(Department department);      

         
    }
}
