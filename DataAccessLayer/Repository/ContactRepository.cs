using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ContactRepository : IContactDal
    {
        public void AddEntity(Contact entity)
        {
            throw new NotImplementedException();
        }

        public List<Contact> categories()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
