using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> AllBlogsByWriter(int WriterId)
        {
            using (var c = new Context())
                return c.Blogs.Where(i => i.WriterId == WriterId).Include(c=>c.category).Include(i=>i.writer).ToList();        
        }

        public List<Blog> AllBlogsWithCategory()
        {
            using (var c = new Context())
                return c.Blogs.Include(c => c.category).ToList();
        }
    }
}
