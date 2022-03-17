using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    class CategoryManager:ICategoryService
    {
        EfCategoryRepository _efCategoryRepository;
        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            _efCategoryRepository = efCategoryRepository;
        }

        public void AddEntity(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> AllEntities()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Category entities)
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
