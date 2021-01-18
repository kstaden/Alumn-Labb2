using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IOccupationRepository
    {
        IQueryable<OccupationSet> GetAll();
        void Create(OccupationSet _occupation);
        void Update(OccupationSet _occupation);
        void Delete(OccupationSet _occupation);

        int GetIdByName(string name);
    }
}
