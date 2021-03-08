using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class HighLight
    {
        [Key]
        public int Id { get; set; }
        public int Start_highlight { get; set; }
        public int End_highlight { get; set; }
        public string highlight_color { get; set; }
        public string comment { get; set; }

        [ForeignKey("CleanArticle")]
        public int HighLights_CleanArticle_Id { get; set; }
        public CleanArticle Highlights_Clean_Article { get; set; }
    }
}
