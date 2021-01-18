using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        IQueryable<EventSet_Activity> IActivityRepository.GetAll()
        {
            using (var db = new osu2008Entities1())
            {
                return db.EventSet_Activity.ToList().AsQueryable();
            }
        }
        EventSet_Activity IActivityRepository.GetById(string ID)
        {
            using (var db = new osu2008Entities1())
            {
                return db.EventSet_Activity.FirstOrDefault(x => x.EventId == ID);
            }
        }
    }
}
