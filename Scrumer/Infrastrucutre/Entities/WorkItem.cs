using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}