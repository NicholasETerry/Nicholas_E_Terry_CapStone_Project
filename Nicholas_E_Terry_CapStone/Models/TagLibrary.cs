using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class TagLibrary
    {
        public List<string> tagLibrary;
        public TagLibrary()
        {
            tagLibrary = new List<string>
              {
                  "no author",
                  "bias",
                  "grammatical errors",
                  "out of date",
                  "unnamed source",
                  "suggestive speak"
              };
        }
    }
}
