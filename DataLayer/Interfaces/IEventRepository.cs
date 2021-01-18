using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IEventRepository
    {
        IQueryable<EventSet> GetAll();
        void Create(EventSet _event);
        void AttachUser(string id, string userID);
        void DeleteById(string eventId);
        EventSet GetTByID(string id);
    }
}
