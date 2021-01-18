using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IAlumniAddressRepository
    {
        IQueryable<AlumniAddressSet> GetAll();
        void Create(AlumniAddressSet _alumniAddress);
        void Update(AlumniAddressSet _alumniAddress);
        void Delete(AlumniAddressSet _alumniAddress);
    }
}
