﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Models
{
    public class UserNameModel
    {
        [Key]
        public int Id { get; set; }
        public string User_name { get; set; }
    }
}
