using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public int TestNumber { get; set; }
        public string TestQuestion { get; set; }
        public string IsCorrect { get; set; }
        public string IsWrongOne { get; set; }
        public string IsWrongTwo { get; set; }
        public string IsWrongThree { get; set; }

        [ForeignKey("UserModel")]
        public int Test_UserModel_Id { get; set; }
        public UserModel Test_UserModel { get; set; }
    }
}
