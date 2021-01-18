using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class AlumniRepository : IAlumniRepository
    {
        public bool CheckUserId(string userId)
        {
            using (var db = new osu2008Entities1())
            {
                return db.UserSet_Alumni.Any(x => x.UserId == userId);
            }
        }

        public void Create(UserSet_Alumni _alumni)
        {
            using (var db = new osu2008Entities1())
            {
                var alumni = _alumni;

                db.UserSet_Alumni.Add(_alumni);
                db.SaveChanges();
            }
        }

        public void Delete(UserSet_Alumni _alumni)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserSet_Alumni> GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.UserSet_Alumni/*.OfType<Activity>()*/.ToList().AsQueryable();
            }
        }

        public void Update(UserSet_Alumni _alumni)
        {
            throw new NotImplementedException();
        }
    }
}
