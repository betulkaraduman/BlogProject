using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly Context _context;

        //public GenericRepository(Context context)
        //{
        //    _context = context;
        //}
        public void AddEntity(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public List<T> categories()
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

        public void UpdateEntity(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
