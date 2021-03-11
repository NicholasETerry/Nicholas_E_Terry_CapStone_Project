using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    
    public class ContributorTestLibrary
    {
        public List<ContributorTest> NewTestLibrary;
        public ContributorTestLibrary()
        {
            NewTestLibrary = TestCreator();
        }
        public List<ContributorTest> TestCreator()
        {
            List<ContributorTest> newTestList = new List<ContributorTest>();

            ContributorTest newTestOne = new ContributorTest
            {
                TestNumber = 1,
                TestQuestion = "Correct the portion in Bold: The first time the United States imported more oil than it exported, Americans should have" +
                               " realized that an energy crisis was imminent and could happen in the future.",
                IsCorrect = "Will be imminent and happening soon.",
                IsWrongOne = "Was imminent and could happen in the future.",
                IsWrongTwo = "Could happen imminently in the future.",
                IsWrongThree = "Was imminent."
            };
            newTestList.Add(newTestOne);

            ContributorTest newTestTwo = new ContributorTest
            {
                TestNumber = 2,
                TestQuestion = "Correct the portion in bold: The dramatic monologue was one poetic form congenial to Rober Browning;" +
                               " it let him explore a character's mind without the simplifications demanded by stage productions.",
                IsCorrect = "Browning, letting him explore",
                IsWrongOne = "Browning; it let him explore",
                IsWrongTwo = "Browning, which let him explore",
                IsWrongThree = "Browning, that lets him explore"
            };
            newTestList.Add(newTestTwo);

            ContributorTest newTestThree = new ContributorTest
            {
                TestNumber = 3,
                TestQuestion = "Correct the portion in bold: At the Constitutional Convention of 1787, the proposal to replace the existiong Articles of" +
                               " Confederation with a federal constitution were met with fierce opposition.",
                IsCorrect = "Were met with",
                IsWrongOne = "Having been met with",
                IsWrongTwo = "Met with",
                IsWrongThree = "Met their"
            };
            newTestList.Add(newTestThree);

            return newTestList;
        }

    }
}
