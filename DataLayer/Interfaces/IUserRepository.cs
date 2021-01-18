using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<UserSet> GetAll();
        void Create(UserSet _user);
        void Update(UserSet _user);
        void Delete(UserSet _user);
        IList<UserSet> ShowConnectedAlumnis(string eventId);
        UserSet GetById(string ID);
    }
}
