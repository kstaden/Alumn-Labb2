using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.BusinessEntities
{
    public class EventModel : EventSet
    {
        public virtual ICollection<EventSet> events { get; set; }

        public EventModel(EventSet events)
        {
            this.Creator = events.Creator;
            this.EndDate = events.EndDate;
            this.EventId = events.EventId;
            this.Name = events.Name;
            this.StartDate = events.StartDate;
            this.UserSets = events.UserSets;
            this.events = new HashSet<EventSet>();
        }
    }
}
