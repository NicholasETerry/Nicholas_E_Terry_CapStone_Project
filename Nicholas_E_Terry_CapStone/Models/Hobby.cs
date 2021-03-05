using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }
        public string Hobby_user { get; set; }

        [ForeignKey("UserModel")]
        public int UserModelId { get; set; }
        public UserModel UserModel { get; set; }
    }
}
