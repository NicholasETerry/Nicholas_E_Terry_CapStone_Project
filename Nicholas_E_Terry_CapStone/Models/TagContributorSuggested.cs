using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class TagContributorSuggested
    {
        [Key]
        public int Id { get; set; }
        public string Attribute { get; set; }

        [ForeignKey("UserModel")]
        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        [ForeignKey("CleanArticle")]
        public int TagCleanArticleId { get; set; }
        public CleanArticle TagCleanArticle { get; set; }
    }
}
