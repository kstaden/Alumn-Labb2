using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.BusinessEntities
{
    public class UserModel : UserSet
    {
        public virtual ICollection<UserSet> users { get; set; }
        public UserModel(UserSet user)
        {
            this.UserId = user.UserId;
            this.Email = user.Email;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Password = user.Password;
            this.PhoneNumber = user.PhoneNumber;
            this.SocialSecurityNumber = user.SocialSecurityNumber;
            this.AdminRights = user.AdminRights;
            this.users = new HashSet<UserSet>();
        }
    }
}
