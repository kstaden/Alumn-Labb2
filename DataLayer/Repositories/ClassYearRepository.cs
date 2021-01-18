using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class ClassYearRepository : IClassYearRepository
    {
        public void Create(ClassYearSet _classYear)
        {
            using (var db = new osu2008Entities1())
            {
                var classYear = _classYear;

                db.ClassYearSet.Add(_classYear);
                db.SaveChanges();
            }
        }

        public void Delete(ClassYearSet _classYear)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClassYearSet> GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.ClassYearSet.ToList().AsQueryable();
            }
        }

        public void Update(ClassYearSet _classYear)
        {
            throw new NotImplementedException();
        }
    }
}
