using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    
    public class TestLibrary
    {
        public List<Test> NewTestLibrary;
        public TestLibrary()
        {
            NewTestLibrary = TestCreator();
        }
        public List<Test> TestCreator()
        {
            List<Test> newTestList = new List<Test>();

            return newTestList;
        }

    }
}
