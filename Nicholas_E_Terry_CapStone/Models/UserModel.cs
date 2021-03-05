using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "First Name")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Last Name")]
        public string Last_name { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Email Address")]
        public string Email_address { get; set; }

        [ForeignKey("UserModelAddress")]
        public int UserAddressId { get; set; }
        public UserModelAddress UserModelAddress { get; set; }

        [ForeignKey("Occupation")]
        public int OccupationId { get; set; }
        public Occupation Occupation { get; set; }

        [ForeignKey("PreviousOccupation")]
        public int PreviousOccupationId { get; set; }
        public PreviousOccupation PreviousOccupation { get; set; }

        [ForeignKey("Education")]
        public int EducationId { get; set; }
        public Education Education { get; set; }

        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        [ForeignKey("Hobby")]
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }

        [ForeignKey("UserNameModel")]
        public int UserNameId { get; set; }
        public UserNameModel UserNameModel { get; set; }

        [ForeignKey("Rank")]
        public int RankId { get; set; }
        public Rank Rank { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
