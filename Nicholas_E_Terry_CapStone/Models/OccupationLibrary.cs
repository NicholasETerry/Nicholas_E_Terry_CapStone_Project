using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class OccupationLibrary
    {
        public List<string> OccupationLibrary;
        public OccupationLibrary()
        {
            OccupationLibrary = new List<string>
                {
                    "Factory Worker",
                    "Lawyer",
                    "Banker",
                    "Police Officer",
                    "Teacher"
                };
        }
    }
}
