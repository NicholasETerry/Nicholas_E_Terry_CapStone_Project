using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Skill_user { get; set; }
        public string Skill_level { get; set; }

        [ForeignKey("UserModel")]
        public int? UserModelId { get; set; }
        public UserModel UserModel { get; set; }
    }
}
