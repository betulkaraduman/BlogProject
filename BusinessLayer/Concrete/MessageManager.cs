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
    public class MessageManager : IMessageService
    {
        IMessageDal messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            this.messageDal = messageDal;
        }

        public void AddEntity(Message entity)
        {
            messageDal.AddEntity(entity);
        }

        public List<Message> AllList()
        {
            return messageDal.AllList();
        }

        public List<Message> AllList(Expression<Func<Message, bool>> filter)
        {
            return messageDal.AllList(filter);
        }

        public void DeleteEntity(Message entities)
        {
            messageDal.DeleteEntity(entities);
        }

        public Message GetByID(int id)
        {
            return messageDal.GetById(id);
        }

        public List<Message> GetInboxListByWriter(int WriterId)
        {
            return messageDal.AllList(i => i.ReveiverId == WriterId);
        }

        public List<Message> GetListWithMessageByWriter(int WriterId)
        {
            return messageDal.GetListWithMessageByWriter(WriterId);
        }

        public void UpdateEntity(Message entity)
        {
            messageDal.UpdateEntity(entity);
        }
    }
}
