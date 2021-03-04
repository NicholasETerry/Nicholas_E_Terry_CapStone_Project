using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public string Highest_level { get; set; }
    }
}
