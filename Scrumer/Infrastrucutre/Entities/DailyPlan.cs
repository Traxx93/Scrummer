using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class DailyPlan
    {
        [Key]
        public int DailyPlanID { get; set; }
        [Required]
        public DateTime Date { get; set; }

        //TODO Put ICollection for WorkItems

    }
}