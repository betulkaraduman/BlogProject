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
           return writerDal.AllList();
        }

        public List<Writer> AllList(Expression<Func<Writer, bool>> filter)
        {
            return writerDal.AllList(filter);
        }

        public void DeleteEntity(Writer entities)
        {
            writerDal.DeleteEntity(entities);
        }

        public Writer GetByID(int id)
        {
            return writerDal.GetById(id);
        }

        public void UpdateEntity(Writer entity)
        {
            writerDal.UpdateEntity(entity);
        }
    }
}
