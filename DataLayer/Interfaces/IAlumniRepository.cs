using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IAlumniRepository
    {
        IQueryable<UserSet_Alumni> GetAll();
        void Create(UserSet_Alumni _alumni);
        void Update(UserSet_Alumni _alumni);
        void Delete(UserSet_Alumni _alumni);

        bool CheckUserId(string userId);
    }
}
