using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.BusinessEntities
{
    public class ActivityModel : EventSet_Activity
    {
        public ActivityModel(EventSet_Activity activity)
        {
            //this.Creator = activity.Creator;
            //this.EndDate = activity.EndDate;
            this.EventId = activity.EventId;
            this.Location = activity.Location;
            this.MaxNoParticipants = activity.MaxNoParticipants;
            //this.Name = activity.Name;
            //this.StartDate = activity.StartDate;
        }
    }
}
