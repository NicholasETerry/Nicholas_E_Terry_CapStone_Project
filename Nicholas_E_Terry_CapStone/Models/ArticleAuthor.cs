using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class ArticleAuthor
    {
        [Key]
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Title { get; set; }
        public string Organization { get; set; }

    }
}

