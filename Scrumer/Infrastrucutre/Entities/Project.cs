using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public string Title { get; set; }


        public virtual ICollection<Sprint> Sprints { get; set; }
    }
}