using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Create(UserSet _user)
        {
            using (var db = new osu2008Entities1())
            {
                var user = _user;

                db.UserSet.Add(_user);
                db.SaveChanges();
            }
        }

        public void Delete(UserSet _user)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserSet> GetAll()
        {
            osu2008Entities1 osu2008Entities1 = new osu2008Entities1();
            var s = from c in osu2008Entities1.UserSet
                    select c;
            return s;
        }

        public UserSet GetById(string ID)
        {
            using (var db = new osu2008Entities1())
            {
                return db.UserSet.FirstOrDefault(x => x.UserId == ID);
            }
        }

        public IList<UserSet> ShowConnectedAlumnis(string eventId)
        {
            using (var db = new osu2008Entities1())
            {
                var join = db.EventSet.Where(c => c.EventId == eventId).Include(z => z.UserSets).FirstOrDefault();
                return join.UserSets.ToList();
            }
        }

        public void Update(UserSet _user)
        {
            throw new NotImplementedException();
        }
    }
}
