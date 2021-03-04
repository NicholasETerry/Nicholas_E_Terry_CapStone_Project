using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class PreviousOccupation
    {
        [Key]
        public int Id { get; set; }
        public string Previous_occupation { get; set; }
        public string experience { get; set; }
    }
}
