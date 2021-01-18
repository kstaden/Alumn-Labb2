using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using DataLayer;
using BusinessLayer.BusinessEntities;

namespace BusinessLayer.Controller
{
    public class AdminController
    {
        private IEventRepository eventRepo = new EventRepository();
        private IUserRepository userRepo = new UserRepository();
        private IActivityRepository activityRepo = new ActivityRepository();
        public List<EventModel> GetEvents()
        {

            List<EventModel> events = new List<EventModel>();
            foreach (EventSet @event in eventRepo.GetAll())
                events.Add(new EventModel(@event));

            return events;
        }
        public List<ActivityModel> GetActivities()
        {

            List<ActivityModel> activities = new List<ActivityModel>();
            foreach (EventSet_Activity activity in activityRepo.GetAll())
                activities.Add(new ActivityModel(activity));

            return activities;
        }
        public void DeleteEvent(string eventId)
        {
            eventRepo.DeleteById(eventId);
        }
        public List<UserModel> GetConnectedAlumnis(string x)
        {
            if (eventRepo.GetTByID(x) != null)
            {
                if (userRepo.ShowConnectedAlumnis(x) != null)
                {
                    List<UserModel> model = new List<UserModel>();
                    foreach (UserSet uses in userRepo.ShowConnectedAlumnis(x))
                        model.Add(new UserModel(uses));
                    return model;
                }
                else return null;
            }
            else return null;
        }
        public void CreateActivity(List<string> list)
        {
            EventSet activity = new EventSet
            {
                Name = list[0],
                Creator = list[1],
                StartDate = list[2],
                EndDate = list[3],
                EventId = list[4]

            };
            eventRepo.Create(activity);
        }

    }
}
