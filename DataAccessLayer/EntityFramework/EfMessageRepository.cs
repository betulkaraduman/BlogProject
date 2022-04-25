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
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetListWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages.Include(i => i.SenderUser).Where(i => i.SenderId == id).ToList();
            }
        }
    }
}
