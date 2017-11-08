using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class WorkItem
    {
        [Key]
        public int WorkItemID { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

    }
}