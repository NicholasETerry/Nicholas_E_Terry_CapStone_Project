using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class SkillLibrary
    {
        public List<String> skillLibrary;
        public SkillLibrary()
        {
            skillLibrary = new List<string> {
            "Public Speaking",
                "Writing", 
                "Self Management", 
                "Networking", 
                "Critical Thinking", 
                "Decision Making", 
                "Math", 
                "Research", 
                "Relaxation",
                "Accounting"
            };
        }

    }
}
