using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class EventRepository : IEventRepository
    {
        public void AttachUser(string id, string userID)
        {
            using (var db = new osu2008Entities1())
            {

                var _event = db.EventSet.Where(x => x.EventId == id).Include(x => x.UserSets).FirstOrDefault();
                var _user = db.UserSet.Where(x => x.UserId == userID).FirstOrDefault();

                _event.UserSets.Add(_user);

                db.SaveChanges();
            }
        }

        public void Create(EventSet _event)
        {
            using (var db = new osu2008Entities1())
            {
                var _entity = _event;
                db.Set<EventSet>().Add(_entity);
                db.SaveChanges();
            }
        }

        public void DeleteById(string eventId)
        {
            using (var db = new osu2008Entities1())
            {
                var entity = db.EventSet.Where(x => x.EventId == eventId).FirstOrDefault();
                db.EventSet.Remove(entity);
                db.SaveChanges();
            }
        }

        public IQueryable<EventSet> GetAll()
        {
            osu2008Entities1 osu2008Entities1 = new osu2008Entities1();
            var s = from c in osu2008Entities1.EventSet
                    select c;
            return s;
        }

        public EventSet GetTByID(string id)
        {
            using (var db = new osu2008Entities1())
            {
                return db.EventSet.FirstOrDefault(x => x.EventId == id);
            }
        }
    }
}
