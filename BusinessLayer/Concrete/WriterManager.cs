using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public void AddEntity(Writer entity)
        {
            writerDal.AddEntity(entity);
        }

        public List<Writer> AllList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> AllList(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Writer entities)
        {
            throw new NotImplementedException();
        }

        public Writer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Writer entity)
        {
            throw new NotImplementedException();
        }
    }
}
