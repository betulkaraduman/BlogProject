using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericService<T> where T:class
    {
        void AddEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entities);
        List<T> AllList();

        List<T> AllList(Expression<Func<T, bool>> filter);
        T GetByID(int id);

    }
}
