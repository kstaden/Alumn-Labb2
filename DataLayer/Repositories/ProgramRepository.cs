using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class ProgramRepository : IProgramRepository
    {
        public void Create(ProgramSet _program)
        {
            using (var db = new osu2008Entities1())
            {
                var program = _program;

                db.ProgramSet.Add(_program);
                db.SaveChanges();
            }
        }

        public void Delete(ProgramSet _program)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProgramSet> GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.ProgramSet.ToList().AsQueryable();
            }
        }

        public void Update(ProgramSet _program)
        {
            throw new NotImplementedException();
        }
    }
}
