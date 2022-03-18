using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

       Context _context=new Context();

        //public GenericRepository(Context context)
        //{
        //    _context = context;
        //}
        public void AddEntity(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public List<T> AllList()
        {
            return _context.Set<T>().ToList();
        }

        public void DeleteEntity(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
         return   _context.Set<T>().Find(id);
        }

        public List<T> AllList(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void UpdateEntity(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
