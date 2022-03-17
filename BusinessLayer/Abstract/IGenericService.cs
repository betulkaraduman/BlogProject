using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericService<T> where T:class
    {
        void AddEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entities);
        List<T> AllEntities();
        T GetByID(int id);

    }
}
