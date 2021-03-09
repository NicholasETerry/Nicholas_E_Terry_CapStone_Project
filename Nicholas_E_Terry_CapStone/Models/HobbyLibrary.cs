using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class HobbyLibrary
    {
        public List<string> hobbyLibrary;
        public HobbyLibrary()
        {
            hobbyLibrary = new List<string>
            {
                "Golf",
                "Painting",
                "Gardening",
                "Swimming",
                "Bird Watching ( Illegally ) "
            };
        }
    }
}
