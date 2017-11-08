using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class Meeting
    {
        [Key]
        public int MeetingID { get; set; }

        

        [StringLength(200)]
        public string DayBefore { get; set; }

        [StringLength(200)]
        public string Today { get; set; }

        [StringLength(200)]
        public string Problems { get; set; }


        public int? SprintID { get; set; }
        [ForeignKey("SprintID")]
        public virtual Sprint Sprint { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }



  
    }
}