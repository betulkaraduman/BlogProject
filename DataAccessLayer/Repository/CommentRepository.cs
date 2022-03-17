using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
   public class CommentRepository : ICommentDal
    {
        public void AddEntity(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> categories()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
