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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddEntity(Blog entity)
        {
            _blogDal.AddEntity(entity);
        }

        public List<Blog> AllBlogsWithCategory()
        {
            return _blogDal.AllBlogsWithCategory();
        }

        public List<Blog> AllBlogsByWriter(int WriterId)
        {
            return _blogDal.AllBlogsByWriter(WriterId);
        }

        public List<Blog> AllList()
        {
            return _blogDal.AllList();
        }

        public void DeleteEntity(Blog entities)
        {
            _blogDal.DeleteEntity(entities);
        }

        public Blog GetByID(int id)
        {
          return  _blogDal.GetById(id);
        }

        public List<Blog> AllList(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.AllList(filter);
        }

        public List<Blog> Last3Blog()
        {
            return _blogDal.AllList().Take(3).ToList();
        }
        public void UpdateEntity(Blog entity)
        {
            _blogDal.UpdateEntity(entity);
        }
        public List<Blog> GetAllBlogById(int id)
        {
           return _blogDal.AllList(x => x.BlogId == id);
        }
    }
}
