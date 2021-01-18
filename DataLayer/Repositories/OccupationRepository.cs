using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class OccupationRepository : IOccupationRepository
    {
        public void Create(OccupationSet _occupation)
        {
            using (var db = new osu2008Entities1())
            {
                var occupation = _occupation;

                db.OccupationSet.Add(_occupation);
                db.SaveChanges();
            }
        }

        public void Delete(OccupationSet _occupation)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OccupationSet> GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.OccupationSet.ToList().AsQueryable();
            }
        }

        public int GetIdByName(string name)
        {
            using (var db = new osu2008Entities1())
            {
                return db.OccupationSet.First(x => x.Name == name).OccupationId;
            }
        }

        public void Update(OccupationSet _occupation)
        {
            throw new NotImplementedException();
        }
    }
}
