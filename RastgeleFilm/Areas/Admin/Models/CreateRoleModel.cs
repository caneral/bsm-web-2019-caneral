﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RastgeleFilm.Areas.Admin.Models
{
    public class CreateRoleModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
