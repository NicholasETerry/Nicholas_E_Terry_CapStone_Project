using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class UserModelAddress
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Street Address")]
        public string Street_address { get; set; }
        [Display(Name ="Zip Code")]
        public int Zip_code { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
