using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly Context _context;

        GenericRepository<T> genericRepository = new GenericRepository<T>();
        public void AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> AllEntities()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(T entities)
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
