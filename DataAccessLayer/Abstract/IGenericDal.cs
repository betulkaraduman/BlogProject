using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
  public  interface IGenericDal<T> where T :class
    {
        public List<T> AllList();
        public void AddEntity(T entity);

        public void UpdateEntity(T entity);


        public void DeleteEntity(T entity);

        public T GetById(int id);

        public List<T> AllList(Expression<Func<T,bool>> filter);
    }
}
