using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.BusinessEntities;

namespace BusinessLayer
{
    public class Session
    {
        public UserModel SessionUser { get; set; }
        public bool UserConnected { get; set; }
        public bool AdminSession { get; set; }


        public Session(UserModel userModel)
        {
            SessionUser = userModel;

            AdminSession = false;
            UserConnected = false;
        }
        public Session()
        {
            //SessionUser
        }
        public void Validate(bool empty)
        {
            UserConnected = false;
            //return UserConnected;
        }
        public void UserRights()
        {
            if (SessionUser.AdminRights == true)
            {
                AdminSession = true;
            }
            UserConnected = true;
        }
        public void Attach(UserModel user)
        {
            SessionUser = user;
        }
    }
}
