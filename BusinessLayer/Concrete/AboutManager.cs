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
    public class AboutManager : IAboutService
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void AddEntity(About entity)
        {
            throw new NotImplementedException();
        }

        public List<About> AllList()
        {
            return aboutDal.AllList();
        }

        public List<About> AllList(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(About entities)
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(About entity)
        {
            throw new NotImplementedException();
        }
    }
}
