using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessEntities
{
    public class ProgramModel : ProgramSet
    {
        public ProgramModel(ProgramSet program)
        {
            this.ProgramId = program.ProgramId;
            this.Section = program.Section;
            this.Name = program.Name;
        }
    }
}
