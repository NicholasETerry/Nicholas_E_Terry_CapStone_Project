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
        public string Article_filepath { get; set; }
        public string UniqueId { get; set; }

        [ForeignKey("ArticleAuthor")]
        public int? ArticleAuthorId { get; set; }
        public ArticleAuthor ArticleAuthor { get; set; }

        [NotMapped]
        public string Comment { get; set; }
        [NotMapped]
        public List<string> ArticleTags { get; set; }

    }
}
