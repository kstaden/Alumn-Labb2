using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.BusinessEntities
{
    public class AlumniAddressModel : AlumniAddressSet
    {
        public AlumniAddressModel(string streetAddress, int zipcode, string city)
        {
            this.StreetAddress = streetAddress;
            this.PostalCode = zipcode;
            this.City = city;
        }
    }
}
