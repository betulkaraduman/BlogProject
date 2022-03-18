using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddEntity(Category entity)
        {
            _categoryDal.AddEntity(entity);
        }

        public List<Category> AllList()
        {
            return _categoryDal.AllList();
        }

        public void DeleteEntity(Category entities)
        {
            _categoryDal.DeleteEntity(entities);
        }

        public Category GetByID(int id)
        {
           return _categoryDal.GetById(id);
        }

        public List<Category> AllList(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.AllList(filter);
        }

        public void UpdateEntity(Category entity)
        {
            _categoryDal.UpdateEntity(entity);
        }
    }
}
