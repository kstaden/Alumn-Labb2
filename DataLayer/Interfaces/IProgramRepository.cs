using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IProgramRepository
    {
        IQueryable<ProgramSet> GetAll();
        void Create(ProgramSet _program);
        void Update(ProgramSet _program);
        void Delete(ProgramSet _program);
    }
}
