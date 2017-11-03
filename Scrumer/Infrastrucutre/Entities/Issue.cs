using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class Issue
    {
        [Key]
        public int IssueID { get; set; }
        [Required]
        public string Subject { get; set; }

        public string Description { get; set; }

        [Required]
        public Type Type { get; set; }
    }
}