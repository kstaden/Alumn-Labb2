using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessEntities
{
    public class AlumniModel : UserSet_Alumni
    {
        public AlumniModel(UserSet_Alumni alumni)
        {
            this.UserId = alumni.UserId;
            //this.AdminRights = alumni.AdminRights;
            //this.Password = alumni.Password;
            //this.SocialSecurityNumber = alumni.SocialSecurityNumber;
            //this.FirstName = alumni.FirstName;
            //this.LastName = alumni.LastName;
            //this.PhoneNumber = alumni.PhoneNumber;
            //this.Email = alumni.Email;
            //this.Occupation = alumni.Occupation;
            //this.AlumniAddress = alumni.AlumniAddress;
            //this.ClassYear = alumni.ClassYear;
            this.OccupationOccupationId = alumni.OccupationOccupationId;
            this.AlumniAddressAlumniAddressId = alumni.AlumniAddressAlumniAddressId;
            this.ClassYearClassYearId = alumni.ClassYearClassYearId;
            this.Credits = alumni.Credits;
            this.HasDegree = alumni.HasDegree;
        }
    }
}
