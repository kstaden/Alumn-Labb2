using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        public void Create(T entity)
        {
            using (var db = new osu2008Entities1())
            {
                var _entity = entity;
                db.Set<T>().Add(_entity);
                db.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.Set<T>().ToList().AsQueryable();
            }
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
