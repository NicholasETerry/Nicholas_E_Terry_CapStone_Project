using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class UserNameModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "User Name")]
        public string User_name { get; set; }
        public int User_points { get; set; }
    }
}
