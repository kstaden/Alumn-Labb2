using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessEntities
{
    public class OccupationModel : OccupationSet
    {
        public OccupationModel(OccupationSet occupation)
        {
            this.OccupationId = occupation.OccupationId;
            this.Name = occupation.Name;
        }
    }
}
