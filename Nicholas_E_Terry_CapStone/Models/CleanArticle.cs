using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class CleanArticle
    {
        [Key]
        public int Id { get; set; }
        public string Lead_paragraph { get; set; }
        public string Source { get; set; }
        public string Word_count { get; set; }
        public string Web_url { get; set; }
        public string Pub_date { get; set; }
        public string News_desk { get; set; }

        [ForeignKey("ArticleAuthor")]
        public int ArticleAuthorId { get; set; }
        public ArticleAuthor ArticleAuthor { get; set; }

        //[ForeignKey("Vote")]                            // Introducing FOREIGN KEY constraint 'FK_CleanArticles_Votes_VoteId' on table 'CleanArticles' may cause cycles or multiple cascade paths. 
        //public int VoteId { get; set; }                 // Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
        //public Vote Vote { get; set; }                  // Could not create constraint or index.See previous errors.



        [ForeignKey("UserSuggestedArticleAttributes")]
        public int UserSuggestedArticleAttributesId { get; set; }
        public UserSuggestedArticleAttribute UserSuggestedArticleAttributes { get; set; }
    }
}
