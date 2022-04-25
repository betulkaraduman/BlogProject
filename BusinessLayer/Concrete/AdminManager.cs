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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }


        public void AddEntity(Admin entity)
        {
            _adminDal.AddEntity(entity);
        }

        public List<Admin> AllList()
        {
            return _adminDal.AllList();
        }

        public List<Admin> AllList(Expression<Func<Admin, bool>> filter)
        {
            return _adminDal.AllList(filter);
        }

        public void DeleteEntity(Admin entities)
        {
            _adminDal.DeleteEntity(entities);
        }

        public Admin GetByID(int id)
        {
            return _adminDal.GetById(id);
        }

        public void UpdateEntity(Admin entity)
        {
            _adminDal.UpdateEntity(entity);
        }
    }
}
