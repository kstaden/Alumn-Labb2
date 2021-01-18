using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IActivityRepository
    {
        IQueryable<EventSet_Activity> GetAll();
        EventSet_Activity GetById(string ID);
    }
}
