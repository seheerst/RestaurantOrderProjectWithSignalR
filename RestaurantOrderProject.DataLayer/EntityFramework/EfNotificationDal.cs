using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DataAccessLayer.Repositories;
using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        private readonly RestaurantOrderContext _context;
        public EfNotificationDal(RestaurantOrderContext context) : base(context)
        {
            _context = context;
        }

        public void ChangeNotificationStatusToFalse(int id)
        {
            var value = _context.Notifications.Find(id);
            value.Status = false;
            _context.SaveChanges();
        }

        public void ChangeNotificationStatusToTrue(int id)
        {
            var value = _context.Notifications.Find(id);
            value.Status = true;
            _context.SaveChanges();
        }

        public List<Notification> GetAllNotificationByStatusFalse()
        {
            return _context.Notifications.Where(x => x.Status == false).ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            var count = _context.Notifications.Where(x => x.Status == false).Count();
            return count;
        }
    }
}
