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
    public class ContactManager : IContactService
    {
        IContactDal ContactDal;

        public ContactManager(IContactDal contactDal)
        {
            ContactDal = contactDal;
        }

        public void AddEntity(Contact entity)
        {
            ContactDal.AddEntity(entity);
        }

        public List<Contact> AllList()
        {
            return ContactDal.AllList();
        }

        public List<Contact> AllList(Expression<Func<Contact, bool>> filter)
        {
            return ContactDal.AllList(filter);
        }

        public void DeleteEntity(Contact entities)
        {
            ContactDal.DeleteEntity(entities);
        }

        public Contact GetByID(int id)
        {
            return ContactDal.GetById(id);
        }

        public void UpdateEntity(Contact entity)
        {
            ContactDal.UpdateEntity(entity);
        }
    }
}
