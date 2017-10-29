using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public ICollection<Member> Members { get; set; }
        [Required]
        public Member ScrumMaster { get; set; }
    }
}