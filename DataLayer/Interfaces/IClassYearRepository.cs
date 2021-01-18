using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IClassYearRepository
    {
        IQueryable<ClassYearSet> GetAll();
        void Create(ClassYearSet _classYear);
        void Update(ClassYearSet _classYear);
        void Delete(ClassYearSet _classYear);
    }
}
