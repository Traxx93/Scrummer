﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }

        [Required]
        public string Title { get; set; }

    }
}