using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class PreviousOccupation
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Previous Occupations")]
        public string Previous_occupation { get; set; }

        [ForeignKey("UserModel")]
        public int UserModelId { get; set; }
        public UserModel UserModel { get; set; }
    }
}
