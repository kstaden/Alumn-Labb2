using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using BusinessLayer.BusinessEntities;

namespace BusinessLayer.Controller
{
    public class LoginController
    {
        private IUserRepository userRepo = new UserRepository();
        List<UserModel> users = new List<UserModel>();
        public Session session = new Session();

        public Session CreateSession(string id, string lösen)
        {
            if (userRepo.GetById(id) != null)
            {
                UserModel user = new UserModel(userRepo.GetById(id));
                if (ValidateUser(user, lösen))
                {
                    session.Attach(user);
                    session.UserRights();
                    return session;
                }
                return null;
            }
            return null;
        }
        public bool ValidateUser(UserModel user, string lösen)
        {
            if (user == null)
            {
                return false;
            }
            else if (user.Password == lösen)
            {
                return true;
            }
            return false;
        }
    }
}
