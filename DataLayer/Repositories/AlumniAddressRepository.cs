using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class AlumniAddressRepository : IAlumniAddressRepository
    {
        public void Create(AlumniAddressSet _alumniAddress)
        {
            using (var db = new osu2008Entities1())
            {
                var alumniAddress = _alumniAddress;

                db.AlumniAddressSet.Add(_alumniAddress);
                db.SaveChanges();
            }
        }

        public void Delete(AlumniAddressSet _alumniAddress)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AlumniAddressSet> GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.AlumniAddressSet.ToList().AsQueryable();
            }
        }

        public void Update(AlumniAddressSet _alumniAddress)
        {
            throw new NotImplementedException();
        }
    }
}
