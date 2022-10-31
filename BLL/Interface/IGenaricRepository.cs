using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IGenaricRepository<T>
    {
        //T Get(int? id);
        //IEnumerable<T> GetAll();//IEnemurable parent of all Collection 
        //int Update(T item);

        //int Add(T item);
        //int Delete(T item);


       Task < T> Get(int? id);
       Task< IEnumerable<T> >GetAll();//IEnemurable parent of all Collection 
      Task<  int> Update(T item);

       Task< int> Add(T item);
      Task<  int> Delete(T item);
    }
}
