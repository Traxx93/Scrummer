using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class Sprint
    {
        [Key]
        public int SprintID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string ScrumGoal { get; set; }

        [Required]
        public ICollection<User> Users { get; set; }

        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
    }
}