using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class ContributorComment
    {
        public class contributorComment
        {
            [Key]
            public int Id { get; set; }
            public string ContributorComment { get; set; }

            [ForeignKey("UserModel")]
            public int? Contributor_Comment_UserModel_Id { get; set; }
            public UserModel Contributor_Comment_UserModel { get; set; }
        }
    }
}
