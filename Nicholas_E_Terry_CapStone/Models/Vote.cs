using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        public string vote { get; set; }

        [ForeignKey("UserNameModel")]
        public int UsernameVoteId { get; set; }
        public UserNameModel UserNameModelVote { get; set; }

        [ForeignKey("CleanArticle")]
        public int CleanArticleVoteId { get; set; }
        public CleanArticle CleanArticleVote { get; set; }

    }
}
