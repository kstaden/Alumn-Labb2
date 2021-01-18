using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using BusinessLayer.BusinessEntities;
using DataLayer;

namespace BusinessLayer.Controller
{
    public class AlumniViewController
    {
        private IActivityRepository activityRepo = new ActivityRepository();
        private IEventRepository eventRepo = new EventRepository();
        public List<EventModel> GetActivities()
        {
            List<EventModel> activities = new List<EventModel>();

            foreach (EventSet activity in eventRepo.GetAll())
                activities.Add(new EventModel(activity));

            return activities;
        }
        public void FindEventId(string eventId, string userId)
        {
            eventRepo.AttachUser(eventId, userId);
        }
    }
}
