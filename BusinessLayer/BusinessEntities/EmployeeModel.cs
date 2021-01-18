using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.BusinessEntities
{
    public class EmployeeModel : UserSet_Employee
    {
        public EmployeeModel(UserSet_Employee employee)
        {
            //this.AdminRights = employee.AdminRights;
            //this.Email = employee.Email;
            //this.Event = employee.Event;
            //this.FirstName = employee.FirstName;
            //this.LastName = employee.LastName;
            //this.Password = employee.Password;
            //this.PhoneNumber = employee.PhoneNumber;
            this.Position = employee.Position;
            //this.SocialSecurityNumber = employee.SocialSecurityNumber;
            this.UserId = employee.UserId;
        }
    }
}
