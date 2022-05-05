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
    public class AppUserManager : IAppUserService
    {

        IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }
        public void AddEntity(AppUser entity)
        {
            _appUserDal.AddEntity(entity);
        }

        public List<AppUser> AllList()
        {
            return _appUserDal.AllList();
        }

        public List<AppUser> AllList(Expression<Func<AppUser, bool>> filter)
        {
           return _appUserDal.AllList(filter);
        }

        public void DeleteEntity(AppUser entities)
        {
            _appUserDal.DeleteEntity(entities);
        }

        public AppUser GetByID(int id)
        {
            return _appUserDal.GetById(id);
        }

        public void UpdateEntity(AppUser entity)
        {
            _appUserDal.UpdateEntity(entity);
        }
    }
}
