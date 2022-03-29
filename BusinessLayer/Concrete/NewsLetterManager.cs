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
    public class NewsLetterManager : INewLetterService
    {

        INewLetterDal newsLetterDal;

        public NewsLetterManager(INewLetterDal newsLetterDal)
        {
            this.newsLetterDal = newsLetterDal;
        }

        public void AddEntity(NewsLetter entity)
        {
            newsLetterDal.AddEntity(entity);
        }

        public List<NewsLetter> AllList()
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> AllList(Expression<Func<NewsLetter, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(NewsLetter entities)
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(NewsLetter entity)
        {
            throw new NotImplementedException();
        }
    }
}
