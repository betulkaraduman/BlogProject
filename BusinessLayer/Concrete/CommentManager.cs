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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentdDal = commentDal;
        }
        public void AddEntity(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> AllList(int id)
        {
            return _commentdDal.AllList(x => x.BlogId == id);
        }

        public List<Comment> AllList(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Comment> AllList()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Comment entities)
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            return _commentdDal.AllList(i => i.BlogId == id).ToList();
        }

        public void UpdateEntity(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
