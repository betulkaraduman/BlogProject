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
    public class NotificationManager : INotificationService
    {

        INotificationDal notificationDal;
        public NotificationManager(INotificationDal NotificationDal)
        {
            this.notificationDal = NotificationDal;
        }

        public void AddEntity(Notification entity)
        {
            notificationDal.AddEntity(entity);
        }

        public List<Notification> AllList()
        {
          return  notificationDal.AllList();
        }

        public List<Notification> AllList(Expression<Func<Notification, bool>> filter)
        {
            return notificationDal.AllList(filter);
        }

        public void DeleteEntity(Notification entities)
        {
            notificationDal.DeleteEntity(entities);
        }

        public Notification GetByID(int id)
        {
            return notificationDal.GetById(id);
        }

        public void UpdateEntity(Notification entity)
        {
            notificationDal.UpdateEntity(entity);
        }
    }
}
