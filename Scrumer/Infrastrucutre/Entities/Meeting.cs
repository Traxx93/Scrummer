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

        [ForeignKey("SprintID")]
        public Sprint Sprint { get; set; }


        [ForeignKey("UserID")]
        public User User{ get; set; }

        [StringLength(200)]
        public string DayBefore { get; set; }

        [StringLength(200)]
        public string Today { get; set; }

        [StringLength(200)]
        public string Problems { get; set; }

    }
}