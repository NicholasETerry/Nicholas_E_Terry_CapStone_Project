using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string comment { get; set; }

        [ForeignKey("UserModel")]
        public int? Comment_UserModel_Id { get; set; }
        public UserModel Comment_UserModel { get; set; }
    }
}
