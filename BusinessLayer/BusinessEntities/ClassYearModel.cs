using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.BusinessEntities
{
    public class ClassYearModel : ClassYearSet
    {
        public ClassYearModel(ClassYearSet classYear)
        {
            this.ClassYearId = classYear.ClassYearId;
        }

        public ClassYearModel(string classYearId)
        {
            this.ClassYearId = classYearId;
        }
    }
}
